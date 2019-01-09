using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Player
{
    public class UnitData
    {
        [Display(Name = "Gear")]
        public List<object> gear { get; set; }
        [Display(Name = "Power")]
        public int power { get; set; }
        [Display(Name = "Combat type")]
        public int combat_type { get; set; }
        [Display(Name = "Base ID")]
        public string base_id { get; set; }
        [Display(Name = "Gear level")]
        public int gear_level { get; set; }
        [Display(Name = "Stats")]
        public Stats stats { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Level")]
        public int level { get; set; }
        [Display(Name = "URL")]
        public string url { get; set; }
        [Display(Name = "Rarity")]
        public int rarity { get; set; }
        [Display(Name = "Ability data")]
        public List<AbilityData> ability_data { get; set; }
        [Display(Name = "Zeta abilities")]
        public List<object> zeta_abilities { get; set; }
    }
}
