using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Player
{
    public class Player
    {
        [Display(Name = "Units")]
        public List<Unit> units { get; set; }
        [Display(Name = "Data")]
        public PlayerData data { get; set; }

        public Unit GetUnitByBaseId(string baseId)
        {
            return this.units.Where(u => u.data.base_id.Equals(baseId)).SingleOrDefault();
        }
    }
}
