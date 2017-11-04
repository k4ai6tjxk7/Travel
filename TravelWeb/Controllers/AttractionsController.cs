using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelWeb.Models;

namespace TravelWeb.Controllers
{
    public class AttractionsController : Controller
    {
        private TravelEntities db = new TravelEntities();

        // GET: Attractions
        public ActionResult Index()
        {
            return View(db.Attractions.ToList());
        }

        // GET: Attractions/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attractions attractions = db.Attractions.Find(id);
            if (attractions == null)
            {
                return HttpNotFound();
            }
            return View(attractions);
        }

        // GET: Attractions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attractions/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Description,Particpation,CityName,Location,Add,Tel,Org,Startdate,Enddate,Charge,Cycle,Noncycle,Website,Px,Py,Class1,Class2,Travellinginfo,Parkinginfo,Createdate,CreateName")] Attractions attractions)
        {
            if (ModelState.IsValid)
            {
                db.Attractions.Add(attractions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attractions);
        }

        // GET: Attractions/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attractions attractions = db.Attractions.Find(id);
            if (attractions == null)
            {
                return HttpNotFound();
            }
            return View(attractions);
        }

        // POST: Attractions/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Description,Particpation,CityName,Location,Add,Tel,Org,Startdate,Enddate,Charge,Cycle,Noncycle,Website,Px,Py,Class1,Class2,Travellinginfo,Parkinginfo,Createdate,CreateName")] Attractions attractions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attractions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attractions);
        }

        // GET: Attractions/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Attractions attractions = db.Attractions.Find(id);
            if (attractions == null)
            {
                return HttpNotFound();
            }
            return View(attractions);
        }

        // POST: Attractions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Attractions attractions = db.Attractions.Find(id);
            db.Attractions.Remove(attractions);
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
