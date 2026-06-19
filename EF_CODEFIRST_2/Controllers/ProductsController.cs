using EF_CODEFIRST_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_CODEFIRST_2.Controllers
{
    public class ProductsController : Controller
    {
        CompanyDBContext db = new CompanyDBContext();

        // GET: Product
        public ActionResult Index(string search = "", string SortColumn = "ProductID", string IconClass = "fa-sort-asc", int page = 1)
        {
            //List<Product> products = db.Products.ToList();

            //Search
            List<Product> products = db.Products.Where(row => row.ProductName.Contains(search)).ToList();// kiểm tra coi có dòng nào có name bằng với search được đưa vào hay không , sau đó hiển thị danh sách
            ViewBag.Search = search;

            //Sort  
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (SortColumn == "ProductID")
            {
                if (IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(row => row.ProductID).ToList();
                }
                else
                {
                    products = products.OrderByDescending(row => row.ProductID).ToList();
                }
            }
            else if (SortColumn == "ProductName")
            {
                if (IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(row => row.ProductName).ToList();
                }
                else
                {
                    products = products.OrderByDescending(row => row.ProductName).ToList();
                }
            }
            else if (SortColumn == "Price")
            {
                if (IconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(row => row.Price).ToList();
                }
                else
                {
                    products = products.OrderByDescending(row => row.Price).ToList();
                }
            }

            //Paging
            int NoOfRecordPrePage = 5;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(products.Count) / Convert.ToDouble(NoOfRecordPrePage)));
            //laasy sl sp chia cho sl sp treen mooxi trang => so trang
            int NoOfRecordToSkip = (page - 1) * NoOfRecordPrePage; // so recodrd can skip ví dụ trang 3 => (3-2 )* 5 = 10 => skip qua 10 sản phẩm
            ViewBag.Page = page;
            ViewBag.NoOfPage = NoOfPages;
            products = products.Skip(NoOfRecordToSkip).Take(NoOfRecordPrePage).ToList();


            //products.Skip(10).Take(5);
            return View(products);
        }

        public ActionResult Detail(int id)
        {

            Product pro = db.Products.Where(Row => Row.ProductID == id).FirstOrDefault();// FirstOrDefault trả về đối tượng đầu tiên ứng với id này
            return View(pro);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {

            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Product product = db.Products.Where(row => row.ProductID == id).FirstOrDefault();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product pro)
        {
            Product product = db.Products.Where(row => row.ProductID == pro.ProductID).FirstOrDefault();

            //Update
            product.ProductName = pro.ProductName;
            product.Price = pro.Price;
            product.DateOfPurchase = pro.DateOfPurchase;
            product.AvailabilityStatus = pro.AvailabilityStatus;
            product.CategoryID = pro.CategoryID;
            product.BrandID = pro.BrandID;
            product.Active = pro.Active;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Product product = db.Products.Where(row => row.ProductID == id).FirstOrDefault();
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(int id, Product p)
        {
            Product product = db.Products.Where(row => row.ProductID == id).FirstOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}