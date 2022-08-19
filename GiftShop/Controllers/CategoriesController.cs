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
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService _service;

        public CategoriesController(ICategoriesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("CategoryName")] Category category)
        {
            if (!ModelState.IsValid) //Checks for requirements in the model
            {
                return View(category);
            }
            _service.Add(category);
            return RedirectToAction(nameof(Index));
        }
    }
}
