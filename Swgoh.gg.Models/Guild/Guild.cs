using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Guild
{
    public class Guild
    {
        [Display(Name = "Players")]
        public List<GuildPlayer> players { get; set; }
        [Display(Name = "Data")]
        public GuildData data { get; set; }
    }
}
