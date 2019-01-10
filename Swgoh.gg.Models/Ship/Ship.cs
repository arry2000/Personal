using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Ship
{
    public class Ship
    {
        public override bool Equals(object obj)
        {
            var item = obj as Ship;

            if (item == null)
            {
                return false;
            }

            return this.base_id.Equals(item.base_id);
        }

        public override int GetHashCode()
        {
            return this.base_id.GetHashCode();
        }

        [Display(Name="Name")]
        public string name { get; set; }
        [Display(Name = "Base id")]
        public string base_id { get; set; }
        [Display(Name = "URL")]
        public string url { get; set; }
        [Display(Name = "Image")]
        public string image { get; set; }
        [Display(Name = "Power")]
        public int power { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Combat type")]
        public int combat_type { get; set; }
        [Display(Name = "Alignment")]
        public string alignment { get; set; }
        [Display(Name = "Categories")]
        public List<string> categories { get; set; }
        [Display(Name = "Ability classes")]
        public List<string> ability_classes { get; set; }
        [Display(Name = "Role")]
        public string role { get; set; }
        [Display(Name = "Capital ship")]
        public bool capital_ship { get; set; }

        public int Level { get; set; }
    }
}
