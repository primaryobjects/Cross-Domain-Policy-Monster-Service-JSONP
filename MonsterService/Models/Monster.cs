using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterService.Models
{
    public class Monster
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Monster()
        {
            Name = "My Guy";
            Description = "My Description";
        }
    }
}