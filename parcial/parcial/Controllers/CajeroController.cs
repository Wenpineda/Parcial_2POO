using parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parcial.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult IndexVista()
        {
            return View();
        }

        [HttpGet]
        public ActionResult correcto()
        {
            return View();
        }
        [HttpGet]
        public ActionResult error()
        {
            return View();
        }


        [HttpPost]
        public ActionResult IndexVista(cajero c)
        {

            if (c.dato % 5 == 0)
            {
                return Redirect("correcto");
            }
            else
            {
                return Redirect("Error");
            }
        }
    }
}