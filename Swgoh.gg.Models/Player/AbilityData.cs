using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Player
{
    public class AbilityData
    {
        [Display(Name = "Is omega?")]
        public bool is_omega { get; set; }
        [Display(Name = "Is zeta?")]
        public bool is_zeta { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Ability tier")]
        public int ability_tier { get; set; }
        [Display(Name = "ID")]
        public string id { get; set; }
        [Display(Name = "Tier max")]
        public int tier_max { get; set; }
    }
}
