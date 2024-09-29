using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica2.Models;
using practica2.Data;

using practica2.ViewModel;

namespace practica2.Controllers
{
    public class CuentaBancaria : Controller
    {
        private readonly ILogger<CuentaBancaria> _logger;
        private readonly ApplicationDbContext _context;


        public CuentaBancaria(ILogger<CuentaBancaria> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var cuentas = from o in _context.DataCuentaBancaria select o;
            
            var viewModel = new CuentaBancariaViewModel
            {
                FormCuentaBancaria = new cuentaBancaria(), 
                ListarCuentaBancaria = cuentas.ToList() 
            };

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Registrar(CuentaBancariaViewModel viewModel)
        {
            if (viewModel.FormCuentaBancaria.Id == 0)
            {
                _context.Add(viewModel.FormCuentaBancaria);
                TempData["Message"] = "Registro exitoso de una nueva cuenta";
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}