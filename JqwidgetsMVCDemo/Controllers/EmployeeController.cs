using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JqwidgetsMVCDemo.Models;

namespace JqwidgetsMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        //http://www.jqwidgets.com/jquery-widgets-demo/demos/aspnetmvc/index.htm?(arctic)

        private EmployeeDBEntities db = new EmployeeDBEntities();

        // GET: /Employee/
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: /Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: /Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EmployeeID,ManagerID,FirstName,LastName,Title,Country,City,Address,HireDate,BirthDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: /Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: /Employee/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EmployeeID,ManagerID,FirstName,LastName,Title,Country,City,Address,HireDate,BirthDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: /Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: /Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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

        public JsonResult GetEmployees()
        {
            var dbResult = db.Employees.ToList();
            var employees = (from employee in dbResult
                             select new
                             {
                                 employee.FirstName,
                                 employee.LastName,
                                 employee.EmployeeID,
                                 employee.BirthDate,
                                 employee.HireDate,
                                 employee.ManagerID,
                                 employee.Title,
                                 employee.City,
                                 employee.Country,
                                 employee.Address
                             });
            return Json(employees, JsonRequestBehavior.AllowGet);
        }

    }
}
