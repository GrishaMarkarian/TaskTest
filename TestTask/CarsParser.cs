using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask
{
    internal class CarsParser
    {
        public async Task ParseFirstPage(string html)
        {
            html = await URLClass.CallUrl(html);
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var programmerLinks = htmlDoc.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "").Contains("dateRange") || node.GetAttributeValue("class", "").Contains("modelCode") ||
                node.GetAttributeValue("class", "").Contains("name") || node.GetAttributeValue("class", "").Contains("id"))
                .ToList();
            ParseFirstPageCar(programmerLinks);
        }
        private async Task ParseFirstPageCar(List<HtmlNode> programmerLinks)
        {
            List<Car> Cars = new List<Car>();

            Car tempCar = null;
            foreach (var link in programmerLinks)
            {
                if (link.Attributes[0].Value == "name")
                {
                    if (tempCar != null)
                    {
                        Cars.Add(tempCar);
                    }
                    tempCar = new Car();
                    tempCar.Name = link.InnerHtml;
                }
                if (link.Attributes[0].Value == "id")
                {
                    if (!string.IsNullOrEmpty(tempCar.Path))
                    {
                        string tempName = "";
                        tempName = tempCar.Name;
                        Cars.Add(tempCar);
                        tempCar = new Car();
                        tempCar.Name = tempName;
                    }
                    tempCar.Id = Regex.Match(link.InnerHtml, ">(?<display>.*)<").Groups["display"].Value;

                }
                if (link.Attributes[0].Value == "dateRange")
                {
                    Regex rgx = new Regex("[^0-9-.]");
                    tempCar.Date = rgx.Replace(link.InnerHtml, "");
                    tempCar.Path = CreatePathForFirstPage(tempCar.Date, tempCar.Id);
                }
                if (link.Attributes[0].Value == "modelCode")
                {
                    tempCar.ModelCode = link.InnerHtml;
                }
            }
            Cars.Add(tempCar);
            SaveDataFirstPageDB(Cars);
        }
        private string CreatePathForFirstPage(string Date, string Code)
        {
            var quest = Date.Split("-");
            string start = "";
            string end = "";
            for (int i = 0; i < quest.Length; i++)
            {
                var t = quest[i].Split(".");
                if (i == 0) start = t[1] + t[0];
                if (i == 1) end = t[1] + t[0];
            }

            if (!string.IsNullOrEmpty(start) && !string.IsNullOrEmpty(end))
            {
                return "https://www.ilcats.ru/toyota/?function=getComplectations&market=EU&model=" + Code + "&startDate=" + start + "&endDate=" + end;
            }
            return "https://www.ilcats.ru/toyota/?function=getComplectations&market=EU&model=" + Code + "&startDate=" + start;
        }

        private void SaveDataFirstPageDB(List<Car> _Car)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (var car in _Car)
                {
                    db.Cars.Add(car);
                }
                db.SaveChanges();
            }
        }
        public static List<Car> GetDataFirstPageDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Cars.ToList();
            }
        }
    }
}
