using Swgoh.gg.Helpers;
using Swgoh.gg.Models.Character;
using Swgoh.gg.Models.Guild;
using Swgoh.gg.Models.Player;
using Swgoh.gg.Models.Ship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Personal.Areas.Swgoh.Controllers
{
    public class SwgohController : Controller
    {
        public SwgohController()
        {
            SwgohClient.Initialize();
        }

        public ActionResult Index()
        {
            return View();
        }

        //Arry's allyCode: 267126851
        public async Task<ViewResult> PlayerDetails(int allyCode)
        {
            Player player = await SwgohApiProcessor.MakeRequest<Player>($"player/{allyCode}");

            player.data.ArenaLeader = await this.GetCharacterByBaseId(player.data.arena_leader_base_id);
            player.data.FleetArenaLeader = await this.GetShipByBaseId(player.data.fleet_arena.leader);
            foreach(string member in player.data.arena.members)
            {
                player.data.ArenaMembers.Add(await this.GetCharacterByBaseId(member));
            }
            foreach(string ship in player.data.fleet_arena.members)
            {
                player.data.FleetArenaMembers.Add(await this.GetShipByBaseId(ship));
            }
            foreach(string ship in player.data.fleet_arena.reinforcements)
            {
                player.data.FleetArenaReinforcements.Add(await this.GetShipByBaseId(ship));
            }

            return View(player);
        }

        // Starforge Omega: 37072
        public async Task<ActionResult> GuildDetails(int guildId)
        {
            Guild guild = await SwgohApiProcessor.MakeRequest<Guild>($"guild/{guildId}");

            return View(guild);
        }

        private async Task<Character> GetCharacterByBaseId(string baseId)
        {
            List<Character> charList =  await SwgohApiProcessor.MakeRequest<List<Character>>("characters");

            return charList.Where(c => c.base_id == baseId).FirstOrDefault();
        }

        private async Task<Ship> GetShipByBaseId(string baseId)
        {
            List<Ship> shipList = await SwgohApiProcessor.MakeRequest<List<Ship>>("ships");

            return shipList.Where(s => s.base_id == baseId).FirstOrDefault();
        }

        //TODO: Make (class library of) ViewModels
        //Gather Models and Create ViewModels (for example: PlayerCharacter == Player.unit data + some character data (name, image ...)
        //Same thing for ships
    }
}