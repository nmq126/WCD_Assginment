using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AssignmentWCD.Data;
using AssignmentWCD.Models;

namespace AssignmentWCD.Controllers
{
    public class ProductsController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: Products
        public ActionResult List()
        {
            var products = db.Products.Include(p => p.Category);
            ViewBag.ListCategory = db.Categories.ToList();
            return View(products.ToList());
        }

        public PartialViewResult FindProductByNameAndCategory()
        {
            var products = db.Products.AsQueryable();
            if (Request.QueryString["categoryId"] != null)
            {
                string categoryId = this.Request.QueryString["categoryId"];
                if (!string.IsNullOrEmpty(categoryId))
                {
                    products = products.Where(s => s.CategoryId.ToString().Contains(categoryId)).Include(p => p.Category);
                }
            }

            if (Request.QueryString["SearchName"] != null)
            {
                string QueryName = this.Request.QueryString["SearchName"];
                if (!String.IsNullOrEmpty(QueryName))
                {
                    products = products.Where(s => s.Name.Contains(QueryName)).Include(p => p.Category);
                }
            }
            return PartialView("FilterProduct", products.ToList());
        }
    }
}
