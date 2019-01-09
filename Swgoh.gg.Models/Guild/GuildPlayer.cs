using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Guild
{
    public class GuildPlayer
    {
        [Display(Name = "Data")]
        public GuildPlayerData data { get; set; }
    }
}
