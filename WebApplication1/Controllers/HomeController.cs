using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.appointments = GetScheduleData();
            return View();
        }

        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Subject = "Paris",
                StartTime = new DateTime(2018, 2, 15, 10, 0, 0),
                EndTime = new DateTime(2018, 2, 15, 12, 30, 0)
            });
            return appData;
        }
        public class AppointmentData
        {
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        }



    }
}