using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Player
{
    public class Unit
    {
        [Display(Name = "Data")]
        public UnitData data { get; set; }
    }
}
