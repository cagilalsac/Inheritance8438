#nullable disable

using GunesSistemi.Models;
using GunesSistemi.Models.Bases;
using GunesSistemi.Services.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesSistemi.Services
{
    public class GokCismiService : IGokCismiService
    {
        GokCismiBase _gokCismi;

        public GokCismiBase DetayGetir(int id)
        {
            _gokCismi = null;
            GokCismiBase[] gokCisimleri = Listele();
            foreach (GokCismiBase gokCismi in gokCisimleri)
            {
                if (gokCismi.Id == id)
                {
                    _gokCismi = gokCismi;
                    break;
                }
            }
            return _gokCismi;
        }

        public GokCismiBase[] Listele()
        {
            //GokCismiBase[] gokCisimleri1 = new GokCismiBase[]
            //{
            //    new Yildiz()
            //    {
            //        Adi = "Güneş",
            //        Id = 0,
            //        SicaklikC = 2000,
            //        YariCap = 5000
            //    },
            //    new Gezegen()
            //    {
            //        Adi = "Dünya",
            //        Id = 3,
            //        YariCap = 500,
            //        YasamVarMi = true,
            //        YildizId = 0
            //    },
            //    new Uydu()
            //    {
            //        Adi = "Ay",
            //        GezegenId = 3,
            //        YariCap = 50,
            //        Id = 11
            //    }
            //};

            GokCismiBase[] gokCisimleri = new GokCismiBase[3];
            _gokCismi = new Yildiz()
            {
                Adi = "Güneş",
                Id = 0,
                SicaklikC = 2000,
                YariCap = 5000,
                GezegenIdleri = new int[]
                {
                    3
                }
            };
            gokCisimleri[0] = _gokCismi;
            _gokCismi = new Gezegen()
            {
                Adi = "Dünya",
                Id = 3,
                YariCap = 500,
                YasamVarMi = true,
                YildizId = 0,
                UyduIdleri = new int[]
                {
                    11
                }
            };
            gokCisimleri[1] = _gokCismi;
            _gokCismi = new Uydu()
            {
                Adi = "Ay",
                GezegenId = 3,
                YariCap = 50,
                Id = 11
            };
            gokCisimleri[2] = _gokCismi;
            return gokCisimleri;
        }
    }
}
