using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if(string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace.");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            // TERNARY/CONDITIONAL OPERATOR

            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            //NULL-COALESCING OPERATOR -- If not null, value of object is returned; if null, we can specify
            //default value

            int days = player.DaysSinceLastLogin?? -11;

            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);

            Console.WriteLine($"{days} days since last login.");

            //if (player.DaysSinceLastLogin.HasValue) //if HasValue is false, this instance is set to null
               
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin);
               
            //}
            //else
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //}

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
            if(player.IsNoob==null)
            {
                Console.WriteLine("Player newbie status is unknown.");
            }
            else if(player.IsNoob == true)
            {
                Console.WriteLine("Player is newbiew");
            }
            else
            {
                Console.WriteLine("Player is experienced.");
            }
        }
    }
}
