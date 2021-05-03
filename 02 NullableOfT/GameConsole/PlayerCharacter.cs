using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public Nullable<int> DaysSinceLastLogin { get; set; } //equivalent to using int? DaysSinceLastLogin
        public Nullable<DateTime> DateOfBirth { get; set; } //set Nullable type here in order to use it
        public bool? IsNoob { get; set; }
    
    }
}
