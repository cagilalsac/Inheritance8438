using GunesSistemi.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesSistemi.Models
{
    public class Yildiz : GokCismiBase
    {
        public float SicaklikC { get; set; }
        public float SicaklikF => SicaklikC * 1.8f + 32;
        public int[] GezegenIdleri { get; set; }
    }
}
