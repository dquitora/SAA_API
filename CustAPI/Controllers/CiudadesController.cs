﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAA_API.Controllers
{
    public class CiudadesController : Controller
    {
        // GET: CiudadesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CiudadesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CiudadesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CiudadesController/Create
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

        // GET: CiudadesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CiudadesController/Edit/5
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

        // GET: CiudadesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CiudadesController/Delete/5
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
