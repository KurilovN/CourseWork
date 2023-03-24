using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClosedXML.Excel;
using CourseWork.Models;

namespace CourseWork.Controllers
{
    public class TransmittedTestimonyController : Controller
    {
        public static int yearR = 0;
        public static int monthR = 0;
        private WaterMeterContext db = new WaterMeterContext();
        // GET: TransmittedTestimony
        public ActionResult Clients(string year, string month)
        {

            int nM = 0;
            if (month == "Январь")
            {
                nM = 1;
            }
            if (month == "Февраль")
            {
                nM = 2;
            }
            if (month == "Март")
            {
                nM = 3;
            }
            if (month == "Апрель")
            {
                nM = 4;
            }
            if (month == "Май")
            {
                nM = 5;
            }
            if (month == "Июнь")
            {
                nM = 6;
            }
            if (month == "Июль")
            {
                nM = 7;
            }
            if (month == "Август")
            {
                nM = 8;
            }
            if (month == "Сентябрь")
            {
                nM = 9;
            }
            if (month == "Октябрь")
            {
                nM = 10;
            }
            if (month == "Ноябрь")
            {
                nM = 11;
            }
            if (month == "Декабрь")
            {
                nM = 12;
            }
            IQueryable<Transmission> transmissions = db.Transmissions;
            List<string> years = new List<string>();
            List<string> months = new List<string>();
            foreach (var item in transmissions)
            {
                years.Add(item.TransmissionDate.Year.ToString());
                months.Add(item.TransmissionDate.Month.ToString());
            }

            if (!String.IsNullOrEmpty(year) && !year.Equals("Все"))
            {
                int y = Int32.Parse(year);
                transmissions = db.Transmissions.Where(x => x.TransmissionDate.Year == y);
                yearR = y;
            }
            if (!String.IsNullOrEmpty(month) && !month.Equals("Все"))
            {
                transmissions = db.Transmissions.Where(x => x.TransmissionDate.Month == nM);
                monthR = nM;
            }

            // устанавливаем начальный элемент, который позволит выбрать всех
            years.Insert(0, "Все");
            var yer = years.Distinct();
            months.Insert(0, "Все");

            CourseWork.Models.Filter plvm = new CourseWork.Models.Filter
            {
                Transmissions = transmissions.ToList(),
                Years = new SelectList(yer),
                Months = new SelectList(new List<string>()
            {
                "Все",
                "Январь",
                "Февраль",
                "Март",
                "Апрель",
                "Май",
                "Июнь",
                "Июль",
                "Август",
                "Сентябрь",
                "Октябрь",
                "Ноябрь",
                "Декабрь"

            })
            };
            return View(plvm);
        }
    }
}