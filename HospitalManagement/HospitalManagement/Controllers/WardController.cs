using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagement.Controllers
{
    public class WardController : Controller
    {
        // GET: Ward
        // GET: Customer/Index
        public ActionResult Index()
        {
            using (DbModelss dbModel = new DbModelss())
            {
                return View(dbModel.Wards.ToList());
            }


        }

        // GET: Ward/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ward/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ward/Create
        [HttpPost]
        public ActionResult Create(Ward ward)
        {
            try
            {
                using (DbModelss db = new DbModelss())
                {
                    db.Wards.Add(ward);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ward/Edit/5
        public ActionResult Edit(int id)
        {

            using (DbModelss dbModel = new DbModelss())
            {
                return View(dbModel.Wards.Where(x => x.RoomTypeCode == id).FirstOrDefault());
            }
        }

        // POST: Ward/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ward ward)
        {
            try
            {
                using (DbModelss dbModel = new DbModelss())
                {
                    dbModel.Entry(ward).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ward/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModelss dbModel = new DbModelss())
            {
                return View(dbModel.Wards.Where(x => x.RoomTypeCode == id).FirstOrDefault());
            }
        }

        // POST: Ward/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using (DbModelss dbModel = new DbModelss())
                {
                    Ward ward = dbModel.Wards.Where(x => x.RoomTypeCode == id).FirstOrDefault();
                    dbModel.Wards.Remove(ward);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
