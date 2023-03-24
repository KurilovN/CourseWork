using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseWork.Models;


namespace CourseWork.Controllers
{
    public class MarkWaterMeterController : Controller
    {
        private WaterMeterContext db = new WaterMeterContext();

        public ActionResult Index()
        {

            return View(db.MarkWaterMeters.ToList());
        }
        public ActionResult Create()
        {

            return View();
        }

        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarkId, NameMark")] MarkWaterMeter tr)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.MarkWaterMeters.Add(tr);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(tr);
                }
            }

            return View(tr);
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarkWaterMeter tr = db.MarkWaterMeters.Find(id);
            if (tr == null)
            {
                return HttpNotFound();
            }
            return View(tr);
        }


        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarkId, NameMark")] MarkWaterMeter tr)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(tr).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(tr);
                }
            }
            return View(tr);
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           MarkWaterMeter tr = db.MarkWaterMeters.Find(id);
            if (tr == null)
            {
                return HttpNotFound();
            }
            return View(tr);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MarkWaterMeter tr = db.MarkWaterMeters.Find(id);
            db.MarkWaterMeters.Remove(tr);
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