using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TeamManagment.UI.ApiService;
using TeamManagment.UI.Models.Core.Context;
using TeamManagment.UI.Models.DAL.Concrete;
using TeamManagment.UI.Models.DAL.Interfaces;
using TeamManagment.UI.Models.DTO;

namespace TeamManagment.UI.Controllers
{
    public class TeamController : Controller
    {
        private readonly IKisiDAL _kisidal;
        private readonly ITakimDAL _takimdal;
        private readonly ITakimKisiDAL _tkdal;
        private readonly KisiBilgiApiService _kisiService;

        public TeamController(KisiBilgiApiService kisiService, IKisiDAL kisidal, ITakimDAL takimdal, ITakimKisiDAL tkdal)
        {
            _kisidal = kisidal;
            _takimdal = takimdal;
            _tkdal = tkdal;
            _kisiService = kisiService;
        }


        public IActionResult Index()
        {
            var teamlist = _takimdal.TakimGetir();
            return View(teamlist);
        }

        public IActionResult EditTeam(int id)
        {
            int takimID = id;
            ViewBag.takimBilgisi = takimID;
            var personlist = _tkdal.TakimUyeliniGetir(id);


            return View(personlist);
        }


        public IActionResult ListPersonForTeam(int unvanID, int takimID)
        {
            var unvanliKisiList = _kisidal.KisiGetir(unvanID);
            ViewBag.takimBilgisi = takimID;
            return View(unvanliKisiList);
        }

        [HttpPost]
        public IActionResult AddPerson(int kisiID, int takimID)
        {
            bool sonuc = _tkdal.TakimaKisiEkle(kisiID, takimID);
            if (sonuc)
            {
                TempData["EklendiMesaji"] = "Kişi takıma başarıyla eklendi.";
                return RedirectToAction("EditTeam", new { id = takimID });
            }
            else
            {
                TempData["HataMesaji"] = "Kişi eklenirken bir hata oluştu.";
                return View("Index");
            }
        }


        [HttpPost]
        public IActionResult RemoveFromTeam(int kisiID, int takimID)
        {
            bool sonuc = _tkdal.TakimdanKisiCikart(kisiID);
            if (sonuc)
            {
                TempData["SilindiMesaji"] = "Kişi takımdan başarıyla çıkartıldı.";
                return RedirectToAction("EditTeam", new { id = takimID });
            }
            else
            {
                TempData["HataMesaji"] = "Kişi eklenirken bir hata oluştu.";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public async Task<IActionResult> KisiBilgi()
        {
            List<KisiBilgiDTO> kisiler = await _kisiService.KisileriListele();
            ViewBag.donenCevap = false;
            if (kisiler != null)
            {
                ViewBag.donenCevap = true;
                return View(kisiler);
            }
            return View(BadRequest());
        }
        [HttpGet]
        public async Task<IActionResult> KisiEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> KisiEkle(KisiDTO eklenecekKisi)
        {
            var donenCevap = await _kisiService.KisiEkle(eklenecekKisi);
            TempData["response"] = donenCevap;
            return RedirectToAction("Info");
        }
        [HttpGet]
        public async Task<IActionResult> Info()
        {
            return View();
        }
    }
}
