using Dona.Globalize.Infra.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;
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
            return View(_db.Products.OrderBy(x => x.DtInsert).ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}