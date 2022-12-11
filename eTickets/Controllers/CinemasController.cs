using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {

        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAll();
            return View(allCinemas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public   IActionResult Create(Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }

            _service.Add(cinema);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult>Details(int id)
        {
            var cinemaDetails =await _service.GetById(id);
            if (cinemaDetails==null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }
        public async Task<IActionResult>Edit(int id)
        {
            var cinemaDetails =await _service.GetById(id);
            if (cinemaDetails==null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }
        [HttpPost]
        public   IActionResult Edit(int id,Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }

            _service.Update(id,cinema);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult>Delete(int id)
        {
            var cinemaDetails =await _service.GetById(id);
            if (cinemaDetails==null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }
    
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id, Cinema actor)
        {
            var actorDetails = await _service.GetById(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }

            await _service.Delete(id);
          
            return RedirectToAction(nameof(Index));
        }
    }
}