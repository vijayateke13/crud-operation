using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class CodersController : Controller
    {
        private workflow_managementEntities db = new workflow_managementEntities();

        // GET: Coders
        public ActionResult Index()
        {
            return                                                                                                   (db.Coders.ToList());
        }

        // GET: Coders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coder coder = db.Coders.Find(id);
            if (coder == null)
            {
                return HttpNotFound();
            }
            return View(coder);
        }

        // GET: Coders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,batch_name,patient_name,pagennumber,DOS,CPT,modifier,ICD_10,comments,coder1")] Coder coder)
        {
            if (ModelState.IsValid)
            {
                
               
                db.Coders.Add(coder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coder);
        }

        // GET: Coders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coder coder = db.Coders.Find(id);
            if (coder == null)
            {
                return HttpNotFound();
            }
            return View(coder);
        }

        // POST: Coders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,batch_name,patient_name,pagennumber,DOS,CPT,modifier,ICD_10,comments,coder1")] Coder coder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coder);
        }

        // GET: Coders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coder coder = db.Coders.Find(id);
            if (coder == null)
            {
                return HttpNotFound();
            }
            return View(coder);
        }

        // POST: Coders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Coder coder = db.Coders.Find(id);
            db.Coders.Remove(coder);
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
