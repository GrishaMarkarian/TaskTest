using HtmlAgilityPack;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace TestTask
{
    public class Programm
    {
        public static async Task Main(string[] args)
        {
            //Парсинг первой страницы
            //CarsParser carsParser = new CarsParser();
            //await carsParser.ParseFirstPage("https://www.ilcats.ru/toyota/?function=getModels&market=EU");

            //Парсинг второй страницы
            //CarsTableParser carsTableParser = new CarsTableParser();
            //await carsTableParser.ParseSecondPage();

            //Парсинг четвертой страницы
            //ParsesListDetails parsesListDetails = new ParsesListDetails();
            //await parsesListDetails.ParseFourPage();

            //Парсинг пятой страницы
            //Не успеел связать с остальной программой
            //DetailsParser detailsParser = new DetailsParser();
            //detailsParser.ParseFivePage("Address");
        }
    }
}