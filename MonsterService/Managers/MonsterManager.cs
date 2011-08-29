using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterService.Models;

namespace MonsterService.Managers
{
    public class MonsterManager
    {
        #region Names

        private static string[] monsterFirstName = new string[10]
        {
            "White",
            "Black",
            "Light",
            "Dark",
            "Evil",
            "Cunning",
            "Magic",
            "Silver",
            "Golden",
            "Slimy"
        };

        private static string[] monsterLastName = new string[10]
        {
            "Gargoyle",
            "Dragon",
            "Wraith",
            "Harpie",
            "Nymph",
            "Serpent",
            "Bat",
            "Chimaera",
            "Hippogryph",
            "Spirit"
        };

        #endregion

        public static Monster CreateRandom()
        {
            Monster monster = new Monster();

            Random random = new Random((int)DateTime.Now.Ticks);

            monster.Name = HelperManager.CreateRandomName(monsterFirstName, monsterLastName);
            monster.Description = "A very scary " + monster.Name + " indeed!";

            return monster;
        }
    }
}