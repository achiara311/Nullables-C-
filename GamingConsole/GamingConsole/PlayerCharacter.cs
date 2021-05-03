using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace GamingConsole
{
   public class PlayerCharacter
    {
        public string Name { get; set; }
        public int DaysSinceLastLogin { get; set; } //cant set to null cause they are value types
        public DateTime DateOfBirth { get; set; } //cant set to null cause they are value types

        public PlayerCharacter()
        {
            DateOfBirth = DateTime.MinValue;
            DaysSinceLastLogin = -1;
        }
    }
}
