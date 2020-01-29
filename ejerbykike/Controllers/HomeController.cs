using ejerbykike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejerbykike.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ejer1()
        {
            return View();
        }

        public ActionResult ejer2()
        {
            return View();
        }

        public ActionResult ejer3()
        {
            return View();
        }
        public ActionResult ejer4()
        {
            return View();
        }
        public ActionResult pares()
        {
            //metemos variables
            var num1 = Request["text1"];
            var num2 = Request["text2"];
            //creamos lista
            List<int> milista2 = new List<int>();
            //creamos objeto primos
            pares mispares = new pares();
            int from, until;
            if ((int.TryParse(num1, out from)) && (int.TryParse(num2, out until)))
            {
                milista2 = mispares.CalculaPar(from, until);
            }
            //retornar la lista
            return View(milista2);

          
        }


        public ActionResult primos()
        {
            //metemos variables
            var num1 = Request["text1"];
            var num2 = Request["text2"];
            //creamos lista
            List<int> milista = new List<int>();
            //creamos objeto primos
            primos misprimos = new primos();
            int from, until;
            if((int.TryParse(num1,out from))&&(int.TryParse(num2,out until)))
            {
                milista = misprimos.CalculaPrimos(from, until);
            }
            //retornar la lista
            return View(milista);
        }
    }
}