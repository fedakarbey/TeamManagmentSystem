using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagment.UI.Models.Core.Context;
using TeamManagment.UI.Models.Core.Entites;
using TeamManagment.UI.Models.DAL.Interfaces;

namespace TeamManagment.UI.Models.DAL.Concrete
{
    public class TakimKisiDAL : ITakimKisiDAL
    {
        public Kisi kisi { get; set; }
        public string UnvanAdi { get; set; }
        public Takim takim { get; set; }

        private readonly MyDBContext _context;
        public TakimKisiDAL(MyDBContext context)
        {
            _context = context;
        }
        public TakimKisiDAL()
        {

        }

        public List<TakimKisi> TakimUyeliniGetir(int takimID)
        {
            List<TakimKisi> hede = _context.TakimKisi.Where(a => a.TakimID == takimID).Select(a => new TakimKisi
            {
                Kisi = new Kisi
                {
                    KisiID = a.Kisi.KisiID,
                    Ad = a.Kisi.Ad,
                    Soyad = a.Kisi.Soyad,
                    Unvan = new Unvan
                    {
                        UnvanID = a.Kisi.Unvan.UnvanID,
                        UnvanAdi = a.Kisi.Unvan.UnvanAdi
                    }
                },
                Takim = new Takim
                {
                    TakimAdi = a.Takim.TakimAdi
                }
            }).ToList();

            return hede;
        }

        public bool TakimdanKisiCikart(int kisiID)
        {
            TakimKisi silinecekKisi = _context.TakimKisi.FirstOrDefault(a => a.KisiID == kisiID);
            try
            {
                _context.TakimKisi.Remove(silinecekKisi);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TakimaKisiEkle(int kisiID, int takimID)
        {
            TakimKisi eklenekKisi = new TakimKisi
            {
                KisiID = kisiID,
                TakimID = takimID
            };
            try
            {
                _context.TakimKisi.Add(eklenekKisi);
               int sonuc = _context.SaveChanges();
                if (sonuc>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
