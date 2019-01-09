using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Models.Player
{
    public class PlayerData
    {
        [Display(Name = "Last updated")]
        public DateTime last_updated { get; set; }
        [Display(Name = "Galactic power")]
        public int galactic_power { get; set; }
        [Display(Name = "PVE Battles won")]
        public int pve_battles_won { get; set; }
        [Display(Name = "GP (Characters)")]
        public int character_galactic_power { get; set; }
        [Display(Name = "Guild contribution")]
        public int guild_contribution { get; set; }
        [Display(Name = "Guild exchange donations")]
        public int guild_exchange_donations { get; set; }
        [Display(Name = "Fleet arena")]
        public FleetArena fleet_arena { get; set; }
        [Display(Name = "Guild ID")]
        public int guild_id { get; set; }
        [Display(Name = "Arena leader base ID")]
        public string arena_leader_base_id { get; set; }
        [Display(Name = "Galactic war won")]
        public int galactic_war_won { get; set; }
        [Display(Name = "PVE Hard won")]
        public int pve_hard_won { get; set; }
        [Display(Name = "Guild name")]
        public string guild_name { get; set; }
        [Display(Name = "Arena rank")]
        public int arena_rank { get; set; }
        [Display(Name = "Guild raid won")]
        public int guild_raid_won { get; set; }
        [Display(Name = "Arena")]
        public Arena arena { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Ally code")]
        public int ally_code { get; set; }
        [Display(Name = "PVP battles won")]
        public int pvp_battles_won { get; set; }
        [Display(Name = "Level")]
        public int level { get; set; }
        [Display(Name = "GP (Ships)")]
        public int ship_galactic_power { get; set; }
        [Display(Name = "Ship battles won")]
        public int ship_battles_won { get; set; }
        [Display(Name = "URL")]
        public string url { get; set; }

        public string SwgohLink
        {
            get
            {
                return $"https://swgoh.gg{ this.url }";
            }
        }

        [Display(Name = "Arena leader")]
        public Character.Character ArenaLeader { get; set; }

        [Display(Name = "Arena members")]
        public List<Character.Character> ArenaMembers { get; set; } = new List<Character.Character>();

        [Display(Name = "Fleet arena leader")]
        public Ship.Ship FleetArenaLeader { get; set; }

        [Display(Name = "Fleet arena members")]
        public List<Ship.Ship> FleetArenaMembers { get; set; } = new List<Ship.Ship>();

        [Display(Name = "Fleet arena reinforcements")]
        public List<Ship.Ship> FleetArenaReinforcements { get; set; } = new List<Ship.Ship>();
    }
}
