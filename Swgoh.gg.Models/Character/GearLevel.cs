using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Character
{
    public class GearLevel
    {
        [Display(Name="Tier")]
        public int tier { get; set; }
        [Display(Name ="Gear")]
        public List<string> gear { get; set; }
    }
}
