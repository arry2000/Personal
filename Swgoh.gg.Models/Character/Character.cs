using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Character
{
    public class Character
    {
        public override bool Equals(object obj)
        {
            var item = obj as Character;

            if (item == null)
            {
                return false;
            }

            return this.pk.Equals(item.pk);
        }

        public override int GetHashCode()
        {
            return this.pk.GetHashCode();
        }
        [Display(Name="Name")]
        public string name { get; set; }
        [Display(Name = "Base Id")]
        public string base_id { get; set; }
        [Display(Name = "PK")]
        public int pk { get; set; }
        [Display(Name = "URL")]
        public string url { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }
        [Display(Name = "Power")]
        public int power { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Combat Type")]
        public int combat_type { get; set; }
        [Display(Name = "Gear levels")]
        public List<GearLevel> gear_levels { get; set; }
        [Display(Name = "Alignment")]
        public string alignment { get; set; }
        [Display(Name = "Categories")]
        public List<string> categories { get; set; }
        [Display(Name = "Ability classes")]
        public List<string> ability_classes { get; set; }
        [Display(Name = "Role")]
        public string role { get; set; }
        [Display(Name = "Ship")]
        public string ship { get; set; }
        [Display(Name = "Ship slot")]
        public object ship_slot { get; set; }
        [Display(Name = "# Shards to activate")]
        public int activate_shard_count { get; set; }

        public int Level { get; set; }
        public int UnitPower { get; set; }
    }
}
