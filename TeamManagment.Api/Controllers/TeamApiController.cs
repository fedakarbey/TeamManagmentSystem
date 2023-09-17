using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.Api.Models.Context;
using TeamManagment.Api.Models.DTOs;
using TeamManagment.Api.Models.Entities;

namespace TeamManagment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamApiController : Controller
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;
        public TeamApiController(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("~/api/kisiDetay")]
        public async Task<IActionResult> Index()
        {
            try
            {
                var kisiListesi = _context.Kisi.Join(_context.OzlukBilgiler, k => k.KisiID, o => o.KisiID, (k, o) => new KisiBilgiDTO
                {
                    KisiID = k.KisiID,
                    Ad = k.Ad,
                    Soyad = k.Soyad,
                    TCNo = o.TCNo,
                    DogumTarihi = o.DogumTarihi,
                    TelefonNo = o.TelefonNo
                }).ToList();
                return Ok(kisiListesi);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("~/api/kisiEkle")]
        public async Task<IActionResult> KisiEkle([FromBody] KisiDTO dto)
        {
            try
            {
                Kisi eklenecekKisi = _mapper.Map<Kisi>(dto);
                await _context.Kisi.AddAsync(eklenecekKisi);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception)
            {
                return NoContent();
            }
        }
    }
}
