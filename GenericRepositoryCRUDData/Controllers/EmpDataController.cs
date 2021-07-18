using GenericRepositoryCRUDData.Models;
using GenericRepositoryCRUDData.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericRepositoryCRUDData.Controllers
{
    public class EmpDataController : Controller
    {
        private IRepository<EmpData> _iEmpData;

        public EmpDataController()
        {
            this._iEmpData = new AllRepository<EmpData>();
        }
        // GET: EmpData
        public ActionResult Index()
        {
            return View(from m in _iEmpData.GetAlldata() select m);
        }

        // GET: EmpData/Details/5
        public ActionResult Details(int id)
        {
            EmpData e = _iEmpData.GetDataByID(id);
            return View(e);
        }

        // GET: EmpData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpData/Create
        [HttpPost]
        public ActionResult Create(EmpData collection)
        {
            try
            {
                // TODO: Add insert logic here
                _iEmpData.InsertData(collection);
                _iEmpData.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpData/Edit/5
        public ActionResult Edit(int id)
        {
            EmpData e = _iEmpData.GetDataByID(id);
            return View(e);
        }

        // POST: EmpData/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmpData collection)
        {
            try
            {
                // TODO: Add update logic here
                _iEmpData.UpdateData(collection);
                _iEmpData.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpData/Delete/5
        public ActionResult Delete(int id)
        {
            EmpData e = _iEmpData.GetDataByID(id);
            return View(e);
        }

        // POST: EmpData/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _iEmpData.DeleteData(id);
                _iEmpData.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
