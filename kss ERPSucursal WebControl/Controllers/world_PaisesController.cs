using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using kss_ERPSucursal_WebControl.Models;

namespace kss_ERPSucursal_WebControl.Controllers
{
    public class world_PaisesController : Controller
    {
        private kssERPSucursaldbEntities db = new kssERPSucursaldbEntities();

        // GET: world_Paises
        public ActionResult Index()
        {
            var world_Paises = db.world_Paises.Include(w => w.world_Idiomas);
            return View(world_Paises.ToList());
        }

        // GET: world_Paises/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            world_Paises world_Paises = db.world_Paises.Find(id);
            if (world_Paises == null)
            {
                return HttpNotFound();
            }
            return View(world_Paises);
        }

        // GET: world_Paises/Create
        public ActionResult Create()
        {
            ViewBag.id_World_Idiomas = new SelectList(db.world_Idiomas, "id_World_Idiomas", "codigo");
            return View();
        }

        // POST: world_Paises/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_World_Paises,id_World_Idiomas,nombre,x,y")] world_Paises world_Paises)
        {
            if (ModelState.IsValid)
            {
                db.world_Paises.Add(world_Paises);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_World_Idiomas = new SelectList(db.world_Idiomas, "id_World_Idiomas", "codigo", world_Paises.id_World_Idiomas);
            return View(world_Paises);
        }

        // GET: world_Paises/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            world_Paises world_Paises = db.world_Paises.Find(id);
            if (world_Paises == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_World_Idiomas = new SelectList(db.world_Idiomas, "id_World_Idiomas", "codigo", world_Paises.id_World_Idiomas);
            return View(world_Paises);
        }

        // POST: world_Paises/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_World_Paises,id_World_Idiomas,nombre,x,y")] world_Paises world_Paises)
        {
            if (ModelState.IsValid)
            {
                db.Entry(world_Paises).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_World_Idiomas = new SelectList(db.world_Idiomas, "id_World_Idiomas", "codigo", world_Paises.id_World_Idiomas);
            return View(world_Paises);
        }

        // GET: world_Paises/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            world_Paises world_Paises = db.world_Paises.Find(id);
            if (world_Paises == null)
            {
                return HttpNotFound();
            }
            return View(world_Paises);
        }

        // POST: world_Paises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            world_Paises world_Paises = db.world_Paises.Find(id);
            db.world_Paises.Remove(world_Paises);
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
