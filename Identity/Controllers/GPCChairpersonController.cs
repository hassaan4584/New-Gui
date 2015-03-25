using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Identity.Models;

namespace Identity.Controllers
{
    public class GPCChairpersonController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /GPCChairperson/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /GPCChairperson/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseRequest purchaserequest = db.PurchaseRequests.Find(id);
            if (purchaserequest == null)
            {
                return HttpNotFound();
            }
            return View(purchaserequest);
        }

        // GET: /GPCChairperson/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /GPCChairperson/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="PR_ID,Issued_by,Issue_Date,current_status,Price,Amount_in_words,Approved_budget,Balance_over_budget,demandID,vendorname,authorized_by,verified_date,Authorization_date")] PurchaseRequest purchaserequest)
        {
            if (ModelState.IsValid)
            {
                db.PurchaseRequests.Add(purchaserequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(purchaserequest);
        }

        // GET: /GPCChairperson/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseRequest purchaserequest = db.PurchaseRequests.Find(id);
            if (purchaserequest == null)
            {
                return HttpNotFound();
            }
            return View(purchaserequest);
        }

        // POST: /GPCChairperson/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="PR_ID,Issued_by,Issue_Date,current_status,Price,Amount_in_words,Approved_budget,Balance_over_budget,demandID,vendorname,authorized_by,verified_date,Authorization_date")] PurchaseRequest purchaserequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchaserequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(purchaserequest);
        }

        // GET: /GPCChairperson/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseRequest purchaserequest = db.PurchaseRequests.Find(id);
            if (purchaserequest == null)
            {
                return HttpNotFound();
            }
            return View(purchaserequest);
        }

        // POST: /GPCChairperson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PurchaseRequest purchaserequest = db.PurchaseRequests.Find(id);
            db.PurchaseRequests.Remove(purchaserequest);
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
