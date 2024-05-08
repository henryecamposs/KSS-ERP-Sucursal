using kss_ERPSucursal_WebControl.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web.Mvc;

namespace kss_ERPSucursal_WebControl.Controllers
{
    public class demoPaisesController : Controller
    {
        private kssERPSucursaldbEntities db = new kssERPSucursaldbEntities();

        // GET: demoPaises
        public ActionResult Index()
        {
            //var world_Paises = db.world_Paises.Include(w => w.world_Idiomas);
            //return View(world_Paises.ToList());
            return View();
        }

        public ActionResult GetPaises()
        {
                var paises = db.world_Paises.OrderBy(a => a.id_World_Paises).ToList();
                return Json(new { data = paises }, JsonRequestBehavior.AllowGet);
        }

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

        // GET: demoPaises/Create
        public ActionResult Create()
        {
            ViewBag.id_World_Idiomas = new SelectList(db.world_Idiomas, "id_World_Idiomas", "codigo");
            return View();
        }

        // POST: demoPaises/Create
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

        // GET: demoPaises/Edit/5
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

        // POST: demoPaises/Edit/5
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

        // GET: demoPaises/Delete/5
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

        // POST: demoPaises/Delete/5
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

        
        //public ActionResult LoadData()
        //{
        //    try
        //    {
        //        //Creating instance of DatabaseContext class  
        //        using (kssERPSucursaldbEntities _context = new kssERPSucursaldbEntities())
        //        {
        //            var draw = Request.Form.GetValues("draw").FirstOrDefault();
        //            var start = Request.Form.GetValues("start").FirstOrDefault();
        //            var length = Request.Form.GetValues("length").FirstOrDefault();
        //            var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
        //            var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
        //            var searchValue = Request.Form.GetValues("search[value]").FirstOrDefault();

        //            //Paging Size (10,20,50,100)    
        //            int pageSize = length != null ? Convert.ToInt32(length) : 0;
        //            int skip = start != null ? Convert.ToInt32(start) : 0;
        //            int recordsTotal = 0;

        //            // Getting all Customer data    
        //            var customerData = (from tempcustomer in _context.world_Paises
        //                                select tempcustomer);
        //            //Sorting    
        //            //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
        //            //    customerData = customerData.OrderBy(sortColumn + " " + sortColumnDir);
        //            //Search    
        //            if (!string.IsNullOrEmpty(searchValue))
        //                customerData = customerData.Where(m => m.nombre == searchValue);

        //            //total number of rows count     
        //            recordsTotal = customerData.Count();
        //            //Paging     
        //            //var data =  customerData.Skip(skip).Take(pageSize).ToList();
        //            //Returning Json Data    
        //            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = customerData.ToList() });
        //            //return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}


        // GET: demoPaises/Details/5
    }
}
