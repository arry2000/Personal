using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Player
{
    public class FleetArena
    {
        [Display(Name = "Members")]
        public List<string> members { get; set; }
        [Display(Name = "Reinforcements")]
        public List<string> reinforcements { get; set; }
        [Display(Name = "Leader")]
        public string leader { get; set; }
        [Display(Name = "Rank")]
        public int rank { get; set; }
    }
}
