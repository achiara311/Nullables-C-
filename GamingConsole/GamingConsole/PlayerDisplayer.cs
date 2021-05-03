using System;
using System.Collections.Generic;
using System.Text;

namespace GamingConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if(player.DaysSinceLastLogin == -1) //using a magic number to be able to semantically use null
                //for DaysSinceLastLogin because the player could have just created a new account
            {
                Console.WriteLine("No value for DaysSinceLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if(player.DateOfBirth == DateTime.MinValue) //MinValue represents smallest DateTime value 
                //that DateTime can represent
                //making say if DateOfBirth is equal to null
            {
                Console.WriteLine("No date of birth specified.");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
        }
    }
}
