using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Guild
{
    public class GuildData
    {
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Member count")]
        public int member_count { get; set; }
        [Display(Name = "Galactic power")]
        public int galactic_power { get; set; }
        [Display(Name = "Rank")]
        public int rank { get; set; }
        [Display(Name = "Profile count")]
        public int profile_count { get; set; }
        [Display(Name = "ID")]
        public int id { get; set; }
    }
}
