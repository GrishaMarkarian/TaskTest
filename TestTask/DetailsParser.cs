using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask
{
    internal class DetailsParser
    {
        public void ParseFivePage(string html)
        {
            HtmlDocument web = new HtmlDocument();
            web.LoadHtml(html);
            string xTitle = "";
            var table = web.DocumentNode.SelectSingleNode("(//table)[1]");
            bool header = true;
            foreach (var row in table.SelectNodes("tr"))
            {
                if (header)
                {
                    // skip header
                    header = false;
                    continue;
                }

                var cells = row.SelectNodes("td");
                if (!row.InnerHtml.Contains("<td>"))
                {
                    xTitle = row.InnerText;
                }
                if (cells != null)
                {
                    SaveDataFifthPageDB(ParseFivePageDate(xTitle, cells));
                }
            }

        }
        private void SaveDataFifthPageDB(Detail detail)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Details.Add(detail);
                db.SaveChanges();
            }
        }
        private Detail ParseFivePageDate(string _XTitle, HtmlNodeCollection cells)
        {
            Detail detail = new Detail();
            var Code = _XTitle.Split(";");
            Regex rgx = new Regex("[^0-9-.]");
            detail.Id = Guid.NewGuid().ToString();
            detail.Code = rgx.Replace(Code[0], "");
            detail.Name = Code[1];
            if (cells[0].InnerText.Contains(";"))
            {
                detail.TreeCode = cells[0].InnerText.Split(";")[2];
            }
            else
            {
                detail.TreeCode = cells[0].InnerText;
            }

            detail.Count = Convert.ToInt32(cells[1].InnerText);
            detail.Date = rgx.Replace(cells[2].InnerText, "");
            detail.Info = cells[3].InnerText;

            return detail;
        }
    }
}
