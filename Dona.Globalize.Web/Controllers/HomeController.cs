using Dona.Globalize.Infra.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Dona.Globalize.Domain;

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

        [HttpPost]
        public ActionResult CreateProduct(Product model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            model.Status = true;
            model.DtInsert = DateTime.Now;
            model.DtLastUpdate = DateTime.Now;

            _db.Products.Add(model);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            model.Status = true;
            model.DtInsert = DateTime.Now;
            model.DtLastUpdate = DateTime.Now;

            _db.People.Add(model);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}