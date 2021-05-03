using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var player = new PlayerCharacter();
            //player.Name = "Sarah";
            // player.DaysSinceLastLogin = 42;

            ////PlayerCharacter player = null;

            //int days = player?.DaysSinceLastLogin ?? -1;

            ////int days;

            ////if(player != null)
            ////{
            ////    days = player.DaysSinceLastLogin ?? -1;
            ////}
            ////else
            ////{
            ////    days = -1;
            ////}

            //Console.WriteLine(days);
            ////PlayerDisplayer.Write(player);


            //Console.ReadLine();

            var ourPlayers = new PlayerCharacter[3]
            {
                new PlayerCharacter {Name= "Sarah"},
                new PlayerCharacter(), //Name = null
                null //PlayerCharacter = null
            };

            //PlayerCharacter[] players = null;

            string p1 = ourPlayers?[0]?.Name;
            string p2 = ourPlayers?[1]?.Name;
            string p3 = ourPlayers?[2]?.Name;
        }
    }
}
