using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingConsole
{
    class Program
    { //USING MAGIC NUMBER TYPES IS NOT RECOMMENDED IN C#, BUT HERES AN EXAMPLE
        static void Main(string[] args)
        {
            var playerOne = new PlayerCharacter();

            playerOne.Name = "Sarah";

            //playerOne.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(playerOne);

            //The constructor of the PlayerCharacter is going to set the magic numbers
            //to represent nulls in its value types 
        }
    }
}
