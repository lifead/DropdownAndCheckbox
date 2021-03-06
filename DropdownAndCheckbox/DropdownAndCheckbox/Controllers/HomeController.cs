﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DropdownAndCheckbox.Models;
using DropdownAndCheckbox.Domain.ViewModels.CheckboxElement;

namespace DropdownAndCheckbox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CheckBoxShow()
        {
            RowCheckboxViewModel[] arrRows = new RowCheckboxViewModel[]
            {
                new RowCheckboxViewModel(),
                new RowCheckboxViewModel() { Edit = true},
                new RowCheckboxViewModel(),
                new RowCheckboxViewModel()
            };

            return View(arrRows);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
