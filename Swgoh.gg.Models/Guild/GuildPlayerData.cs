using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Guild
{
    public class GuildPlayerData
    {
        [Display(Name = "Ally code")]
        public int ally_code { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Level")]
        public int level { get; set; }

        [Display(Name = "Galactic power")]
        public int galactic_power { get; set; }
    }
}
