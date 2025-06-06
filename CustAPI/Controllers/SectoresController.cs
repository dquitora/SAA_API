﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAA_API.Controllers
{
    public class SectoresController : Controller
    {
        // GET: SectoresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SectoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SectoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SectoresController/Create
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

        // GET: SectoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SectoresController/Edit/5
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

        // GET: SectoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SectoresController/Delete/5
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
