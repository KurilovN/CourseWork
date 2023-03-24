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
    [Authorize(Roles = "admin")]
    public class ClientController : Controller
    {
        private WaterMeterContext db = new WaterMeterContext();

        public ActionResult Index()
        {

            return View(db.Clients.ToList());
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonalAccount,Adress,FIO")] Client divizion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Clients.Add(divizion);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
                catch
                {
                    return View(divizion);
                }
            }

            return View(divizion);
        }


        public ActionResult Edit(string PersonalAccount)
        {
            if (PersonalAccount == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client divizion = db.Clients.Find(PersonalAccount);
            if (divizion == null)
            {
                return HttpNotFound();
            }
            return View(divizion);
        }


        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonalAccount,Adress,FIO")] Client divizion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(divizion).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(divizion);
                }
            }
            return View(divizion);
        }


        public ActionResult Delete(string PersonalAccount)
        {
            if (PersonalAccount == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client divizion = db.Clients.Find(PersonalAccount);
            if (divizion == null)
            {
                return HttpNotFound();
            }
            return View(divizion);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string PersonalAccount)
        {
            Client divizion = db.Clients.Find(PersonalAccount);
            db.Clients.Remove(divizion);
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