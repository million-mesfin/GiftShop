using GiftShop.Data;
using GiftShop.Data.Services;
using GiftShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftShop.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemsService _service;
        public ItemsController(IItemsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll(); ;
            return View(data);
        }

        //Create new category
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            if (!ModelState.IsValid) //Checks for requirements in the model
            {
                return View(item);
            }
            _service.Add(item);
            return RedirectToAction(nameof(Index));
        }

        //Details
        public async Task<IActionResult> Details (int id)
        {
            var details = await _service.GetById(id);

            if (details == null)
                return View("NotFound");
            else
                return View(details);
        }

        //Delete Item
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _service.GetById(id);
            if (item == null)
                return View("NotFound");


            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _service.GetById(id);
            if (item == null)
                return View("NotFound");

            await _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        //Update Items
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _service.GetById(id);
            if (item == null)
                return View("NotFound");


            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, ItemName, ImageURL, Price, AvailabilityStatus, Description, CategoryId")] Item item)
        {
            if (!ModelState.IsValid) //Checks for requirements in the model
            {
                return View(item);
            }
            _service.Update(id, item);
            return RedirectToAction(nameof(Index));
        }
    }
}
