using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask
{
    internal class CarsTableParser
    {
        public async Task ParseSecondPage()
        {
            var Cars = CarsParser.GetDataFirstPageDB();
            var Path = await GetPage(Cars);
            for (int i = 0; i < Path.Count; i++)
            {
                await ParseSecondPageParam(Path[i], Cars[i].Id);
            }
        }
        private static async Task<List<string>> GetPage(List<Car> Cars)
        {
            List<Task<string>> tasks = new List<Task<string>>();
            for (int i = 0; i < Cars.Count; i++)
            {
                tasks.Add(URLClass.CallUrl(Cars[i].Path));
                await Task.Delay(100);
            }
            IEnumerable<string> results = await Task.WhenAll(tasks);
            return results.ToList();
        }
        private async Task ParseSecondPageParam(string html, string CarId)
        {
            HtmlDocument web = new HtmlDocument();
            web.LoadHtml(html);
            var programmerLinks_2 = web.DocumentNode.Descendants("th").ToList();
            var result = programmerLinks_2.SkipLast((programmerLinks_2.Count / 2) - 1);

            var table = web.DocumentNode.SelectSingleNode("(//table)[1]");
            bool header = true;
            foreach (var row in table.SelectNodes("tr"))
            {
                if (header)
                {
                    header = false;
                    continue;
                }

                var cells = row.SelectNodes("td");
                var CarTable = await ParseSecondPageCarTable(cells, result, CarId);
                CarTable.Car_Id = CarId;
                SaveDataSecondPageDB(CarTable);
            }

        }
        private async Task<CarsTable> ParseSecondPageCarTable(HtmlNodeCollection htmlNodes, IEnumerable<HtmlNode> htmlresult, string CarId)
        {
            int Counter = 0;
            CarsTable carsTable = new CarsTable();
            foreach (var res in htmlresult)
            {
                if (Counter == 0)
                {
                    string path = "https://www.ilcats.ru/toyota/?function=getSubGroups&market=EU&model=" + CarId + "&modification=" + htmlNodes[Counter].InnerText + "&group=1";

                    carsTable.Path = path;
                    carsTable.Complectation = htmlNodes[Counter].InnerText;
                }
                else if (Counter == 1)
                {
                    Regex rgx = new Regex("[^0-9-.]");
                    carsTable.Date = rgx.Replace(htmlNodes[Counter].InnerText, "");
                }
                else
                {
                    ParseDataSecondPage(carsTable, res.InnerHtml, htmlNodes[Counter].InnerText);
                }
                Counter++;

            }

            Console.WriteLine(carsTable.Complectation);

            return carsTable;
        }
        private void ParseDataSecondPage(CarsTable carsTable, string res, string htmlNodes)
        {
            if (res == "Комплектация")
            {
                carsTable.Complectation = htmlNodes;
            }
            if (res == "Дата")
            {
                carsTable.Date = htmlNodes;
            }
            if (res == "BODY")
            {
                carsTable.Body = htmlNodes;
            }

            if (res == "GRADE")
            {
                carsTable.Grade = htmlNodes;
            }
            if (res == "ATM,MTM")
            {
                carsTable.ATM_MTM = htmlNodes;
            }
            if (res == "GEAR SHIFT TYPE")
            {
                carsTable.Gear_Shift_Type = htmlNodes;
            }
            if (res == "CAB")
            {
                carsTable.Cab = htmlNodes;
            }
            if (res == "TRANSMISSION MODEL")
            {
                carsTable.Transmission_Model = htmlNodes;
            }
            if (res == "ENGINE 1")
            {
                carsTable.Engine_1 = htmlNodes;
            }
            if (res == "ENGINE 2")
            {
                carsTable.Engine_2 = htmlNodes;
            }
            if (res == "LOADING CAPACITY")
            {
                carsTable.Loading_Capacity = htmlNodes;
            }
            if (res == "REAR TIRE")
            {
                carsTable.Rear_Tire = htmlNodes;
            }
            if (res == "DESTINATION")
            {
                carsTable.Destination = htmlNodes;
            }
            if (res == "FUEL INDUCTION")
            {
                carsTable.Fuel_Induction = htmlNodes;
            }
            if (res == "BUILDING CONDITION")
            {
                carsTable.Bulding_Condition = htmlNodes;
            }
            if (res == "PRODUCT")
            {
                carsTable.Product = htmlNodes;
            }
            if (res == "DRIVER'S POSITION")
            {
                carsTable.Drivers_Position = htmlNodes;
            }
            if (res == "NO.OF DOORS")
            {
                carsTable.NOOF_DOORS = htmlNodes;
            }
            if (res == "DESTINATION 1")
            {
                carsTable.Destination_1 = htmlNodes;
            }
            if (res == "DESTINATION 2")
            {
                carsTable.Destination_2 = htmlNodes;
            }
            if (res == "ROOF")
            {
                carsTable.ROOF = htmlNodes;
            }
            if (res == "BODY 1")
            {
                carsTable.Body_1 = htmlNodes;
            }
            if (res == "BODY 2")
            {
                carsTable.Body_2 = htmlNodes;
            }
            if (res == "SEATING CAPACITY")
            {
                carsTable.Seating_Capasity = htmlNodes;
            }
            if (res == "REAR TIME")
            {
                carsTable.Rear_Time = htmlNodes;
            }
            if (res == "VEHICLE MODEL")
            {
                carsTable.Vehicle_Model = htmlNodes;
            }
            if (res == "SIDE WINDOW")
            {
                carsTable.Side_Window = htmlNodes;
            }
            if (res == "MODEL MARK")
            {
                carsTable.Model_Mark = htmlNodes;
            }
            if (res == "DESK")
            {
                carsTable.Desk = htmlNodes;
            }
            if (res == "TOP BACK DORR")
            {
                carsTable.Top_Back_Dorr = htmlNodes;
            }
            if (res == "ROLL BAR")
            {
                carsTable.Roll_Bar = htmlNodes;
            }
            if (res == "EMISSION REGULATION")
            {
                carsTable.Emission_Regulation = htmlNodes;
            }
            if (res == "TRUCK OR VAN")
            {
                carsTable.Truck_Or_Van = htmlNodes;
            }
            if (res == "DECK,CAB")
            {
                carsTable.DECK_CAB = htmlNodes;
            }
            if (res == "DECK(MATERIAL)")
            {
                carsTable.DECK_MATERIAL = htmlNodes;
            }
        }
        public static List<CarsTable> GetDataSecondPageDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.CarsTables.ToList();
            }
        }
        private void SaveDataSecondPageDB(CarsTable CarsTable)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.CarsTables.Add(CarsTable);
                db.SaveChanges();
            }
        }
    }
}
