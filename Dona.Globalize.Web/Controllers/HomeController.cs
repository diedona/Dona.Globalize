using Dona.Globalize.Infra.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Dona.Globalize.Web.Controllers
{
    public class HomeController : Controller
    {
        GlobalizeDataContext _db;

        public HomeController()
        {
            _db = new GlobalizeDataContext();
        }
        public ActionResult Index()
        {
            ViewBag.People = _db.People.ToList();
            ViewBag.Products = _db.Products.ToList();
            return View();
        }

        public ActionResult CreateProduct()
        {
            return View();
        }
        public ActionResult CreatePerson()
        {
            return View();
        }
    }
}