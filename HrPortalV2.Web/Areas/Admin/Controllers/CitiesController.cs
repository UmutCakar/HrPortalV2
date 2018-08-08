﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HrPortalV2.Data;
using HrPortalV2.Models;
using HrPortalV2.Service;

namespace HrPortalV2.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CitiesController : Controller
    {
        private readonly ICityService cityService;
        private readonly IResumeService resumeService;

        public CitiesController(ICityService cityService, IResumeService resumeService)
        {
            this.cityService = cityService;
            this.resumeService = resumeService;
        }

        // GET: Admin/Cities
        public IActionResult Index()
        {
            return View(cityService.GetAll());
        }

        // GET: Admin/Cities/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = cityService.Get(id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // GET: Admin/Cities/Create
        public IActionResult Create()
        {
            ViewBag.CityId = new SelectList(cityService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Admin/Cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Id,CreateDate,CreatedBy,UpdateDate,UpdatedBy,IPAddress")] City city)
        {
            if (ModelState.IsValid)
            {
                cityService.Insert(city);
                return RedirectToAction(nameof(Index));
            }

            return View(city);
        }

        // GET: Admin/Cities/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = cityService.Get(id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // POST: Admin/Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, [Bind("Name,Id,CreateDate,CreatedBy,UpdateDate,UpdatedBy,IPAddress")] City city)
        {
            if (id != city.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cityService.Update(city);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityExists(city.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(city);
        }

        // GET: Admin/Cities/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = cityService.Get(id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // POST: Admin/Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {

            cityService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(string id)
        {
            return cityService.GetAll().Any(c => c.Id == id);
        }
    }
}
