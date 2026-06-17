using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_CODEFIRST_2.Models;

namespace EF_CODEFIRST_2.Controllers
{
    public class CategoriesController : Controller
    {

        // GET: Category
        public ActionResult Index()
        {
            CompanyDBContext db = new CompanyDBContext();
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }
    }
}