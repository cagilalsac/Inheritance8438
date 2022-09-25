using GunesSistemi.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesSistemi.Services.Bases
{
    public interface IGokCismiService
    {
        GokCismiBase[] Listele();
    }
}
