using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAA_API.Controllers
{
    public class MaterialesController : Controller
    {
        // GET: MaterialesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MaterialesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MaterialesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MaterialesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MaterialesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MaterialesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MaterialesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MaterialesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
