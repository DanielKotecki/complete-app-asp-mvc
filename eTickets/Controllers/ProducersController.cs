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
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService producersService)
        {
            _service = producersService;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAll();
            return View(allProducers);
        }

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }

            _service.Add(producer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }

            if (id == producer.Id)
            {
                await _service.Update(id, producer);
                return RedirectToAction(nameof(Index));
            }

            return View(producer); 
        }
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetById(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }

            await _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}