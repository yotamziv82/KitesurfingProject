using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KiteSurfingFinalProject.DAL;
using KiteSurfingFinalProject.Models;
using PagedList;

namespace KiteSurfingFinalProject.Controllers
{
    public class ProductController : Controller
    {
        private UserContext db = new UserContext();

        // GET: Product
        //public ActionResult Index()
        //{
        //    var products = db.Products.Include(p => p.user );
        //    return View(products.ToList());
        //}

        // GET: Product
        public ActionResult Index(string Sorting_Order, string Search_Data) // , string Filter_Value, int? Page_No
        {
            //ViewBag.CurrentSortOrder = Sorting_Order;
            ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "Company_Name" : "";
            ViewBag.SortingDate = Sorting_Order == "Date_Surf" ? "Date_Description" : "Date";

            //if (Search_Data != null)
            //{
            //    Page_No = 1;
            //}
            //else
            //{
            //    Search_Data = Filter_Value;
            //}

            //ViewBag.FilterValue = Search_Data;

            var products = from stu in db.Products select stu;

            switch (Search_Data)
            {
                case null:  // Performing Sorting
                    {
                        switch (Sorting_Order)
                        {
                            case "Company_Name":
                                products = products.OrderByDescending(pro => pro.Company);
                                break;
                            case "Date_Surf":
                                products = products.OrderBy(pro => pro.Date);
                                break;
                            case "Date_Description":
                                products = products.OrderByDescending(pro => pro.Date);
                                break;
                            default:
                                products = products.OrderBy(pro => pro.Company);
                                break;
                        }
                        return View(products.ToList());
                    }

                case "":
                    {
                        switch (Sorting_Order)
                        {
                            case "Company_Name":
                                products = products.OrderByDescending(pro => pro.Company);
                                break;
                            case "Date_Surf":
                                products = products.OrderBy(pro => pro.Date);
                                break;
                            case "Date_Description":
                                products = products.OrderByDescending(pro => pro.Date);
                                break;
                            default:
                                products = products.OrderBy(pro => pro.Company);
                                break;
                        }
                        return View(products.ToList());
                    }

                default:    // Performing Search
                    {
                        products = products.Where(pro => pro.Company.ToUpper().Contains(Search_Data.ToUpper())
                            || pro.Description.Contains(Search_Data.ToUpper()));
                    }
                    return View(products.ToList());
                    //int Size_Of_Page = 4;
                    //int No_Of_Page = (Page_No ?? 1);
                    //return View(products.ToPagedList(No_Of_Page, Size_Of_Page));

        //                                           // GET: Product/All
        //public PartialViewResult All()
        //{
        //    List<Product> model = db.Products.ToList();
        //    return PartialView("Product", model);
        //}
        //// GET: Product/NewestPosts
        //public PartialViewResult NewestPosts()
        //{
        //    List<Product> model = db.Products.OrderByDescending(x => x.Date).Take(30).ToList();
        //    return PartialView("Product", model);
        //}
        //// GET: Product/MostExpesive
        //public PartialViewResult MostExpesive()
        //{
        //    List<Product> model = db.Products.OrderByDescending(x => x.Price).Take(30).ToList();
        //    return PartialView("Product", model);
        //}

            }

        }


        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Users, "UserID", "FirstName");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductTypeID,UserID,Company,Size,Year,Description,Price,Date")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.Users, "UserID", "FirstName", product.UserID);
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "UserID", "FirstName", product.UserID);
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductTypeID,UserID,Company,Size,Year,Description,Price,Date")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.Users, "UserID", "FirstName", product.UserID);
            return View(product);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
