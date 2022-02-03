using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PBLKatamaran.Models;

namespace PBLKatamaran.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Pomiary()
        {
            return View();
        }

        public ActionResult GetData()
        {
            Katamaran25102021Entities context = new Katamaran25102021Entities();
            //KatamaranEntities1 context = new KatamaranEntities1();
            //  var data = context.IonSelectiveMeasurements.ToList();

            var query = context.IonSelectiveMeasurements.ToList()
                .Select(g => new { date = g.RESP_TIME.ToString(), mv0 = g.mV_CH0, mv1 = g.mV_CH1, mv2 = g.mV_CH2, mv3 = g.mV_CH3, mv4 = g.mV_CH4, mv5 = g.mV_CH5, mv6 = g.mV_CH6 }).ToList();
            return Json(query, JsonRequestBehavior.AllowGet);


            


        }

        public ActionResult GetDataFromElmetron()
        {

            Katamaran25102021Entities context = new Katamaran25102021Entities();


            var query = context.ElmetronMeasurements.ToList()
                .Select(g => new { ID = g.ID, date = g.RESP_TIME.ToString(), PH = g.pH, Conductivity = g.Conductivity, mV = g.mV, O2 = g.OxygenContent, temperature = g.Temperature, lat = g.LATITUDE, lon = g.LONGITUDE }).ToList();
             //.Select(g => new { date = g.RESP_TIME.ToString(), O2= g.OxygenContent, T = g.Temperature }).ToList();
             //.GroupBy(a => a.ID)
            return Json(query, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetDataFromDeepModules()
        {

            Katamaran25102021Entities context = new Katamaran25102021Entities();


            var query = context.DeepModule.ToList()
                .Select(g => new { date = g.RESP_TIME.ToString(), Temperature = g.HEADING }).ToList();
            return Json(query, JsonRequestBehavior.AllowGet);




        }













        public ActionResult StartPage()
        {
            return View();
        }
        public ActionResult Mapa()
        {
            return View();
        }
        public ActionResult Diagnostyka()
        {
            return View();
        }
    }
}