using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesSistemi.Models.Bases
{
    public abstract class GokCismiBase
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double YariCap { get; set; }
    }
}
