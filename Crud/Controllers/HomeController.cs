using Crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly söförContext _context;

        public HomeController(ILogger<HomeController> logger, söförContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.SöförListe = _context.Söförler.ToList();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Index(Söförler söför)
        {
            _context.Add(söför);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Söför_Guncelle(int ID)
        {
            var guncellenecek_kisi = _context.Söförler.Find(ID);
            return View(guncellenecek_kisi);
        }
        [HttpPost]
        public IActionResult Söför_Guncelle(Söförler söför)
        {
            _context.Update(söför);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Söför_Sil(int ID)
        {
            var Silinecek_Söför = await _context.Söförler.FindAsync(ID);
            _context.Remove(Silinecek_Söför);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
