using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockAssessment7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamingController : ControllerBase
    {
        GameDB DB = new GameDB();

        [HttpGet("Players")]
        public List<Player> Players()
        {            
            return DB.Players;
        }
        
        [HttpGet("Classes")]
        public List<PlayerClass> Classes()
        {
            return DB.PlayerClasses;
        }

        [HttpGet("PlayerminLevel")]
        public List<Player> PlayersMinLevel(int level)
        {
            return DB.Players.Where(p => p.Level >= level).ToList();
        }
        [HttpGet("PlayersSortLevel")]

        public List<Player> PlayersSortLevel()
        {
            return DB.Players.OrderByDescending(p => p.Level).ToList();
        }

        [HttpGet("playerOfClass")]
        public List<Player> PlayersOfClass(string name)
        {
            return DB.Players.Where(p => p.CurrentClass.Name == name).ToList();
        }
        [HttpGet("PlayersOfType")]
        public List<Player> PlayersOfType(string type)
        {
            return DB.Players.Where(t => t.CurrentClass.Type == type).ToList();
        }

        [HttpGet("AllPlayedClasses")]

        public List<PlayerClass> GetUsedClasses()
        {

            return DB.Players.Select(p => p.CurrentClass).Distinct().ToList();//returning the property. So we used the select statement


        }

        [HttpPost("AddClass")]
        public PlayerClass AddClass(int id, string name, string type)
        {
            PlayerClass newClass = new PlayerClass(id, name, type);
            DB.PlayerClasses.Add(newClass);
            return newClass;//we can return some messages here instead of the class but the return type should be string
        }


    }
}
