using AssignmentWCD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentWCD.Controllers
{
    public class CartsController : Controller
    {
        public double CalculateTotalPrice(Dictionary<int, CartItem> Items)
        {
            double total = 0;
            foreach (var i in Items.Values)
            {
                total += i.Quantity * i.UnitPrice;
            }
            return total;
        }
        // GET: Carts
        public ActionResult Index()
        {
            if (Session["carts"] == null)
            {
                return View();
            }
            Cart carts = (Cart)Session["carts"];
            List<CartItem> listItems = new List<CartItem>();
            foreach (CartItem i in carts.ListItem.Values)
            {
                listItems.Add(i);
            }
            ViewBag.TotalPrice = carts.TotalPrice;
            return View(listItems);
        }
        public ActionResult AddToCart(CartItem item)
        {
            if (Session["carts"] == null)
            {
                Session["carts"] = new Cart();
            }

            Cart carts = (Cart)Session["carts"];
            var existItem = carts.ListItem.ContainsKey(item.ProductId);
            if (!existItem)
            {
                item.Quantity = 1;
                carts.ListItem.Add(item.ProductId, item);
            }
            else
            {
                carts.ListItem[item.ProductId].Quantity++;
            }

            carts.TotalPrice = CalculateTotalPrice(carts.ListItem);
            Session["carts"] = carts;
            return RedirectToAction("Index");
        }
        public ActionResult UpdateCart(CartItem item)
        {
            Cart carts = (Cart)Session["carts"];
            if (!carts.ListItem.ContainsKey(item.ProductId))
            {
                throw new Exception("Product not found");
            }
            CartItem existItem = carts.ListItem[item.ProductId];
            existItem.Quantity = item.Quantity;
            carts.ListItem[existItem.ProductId] = existItem;

            carts.TotalPrice = CalculateTotalPrice(carts.ListItem);
            Session["carts"] = carts;
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int ProductId)
        {
            Cart carts = (Cart)Session["carts"];
            if (!carts.ListItem.ContainsKey(ProductId))
            {
                throw new Exception("Product not found");
            }
            carts.ListItem.Remove(ProductId);
            carts.TotalPrice = CalculateTotalPrice(carts.ListItem);
            Session["carts"] = carts;
            return RedirectToAction("Index");
        }
    }
}