using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    { 
        private readonly SpecialDefense _specialDefense;

        public PlayerCharacter(SpecialDefense specialDefense)
        {
            _specialDefense = specialDefense;
        }
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //if(_specialDefense != null) //if you dont have this set up, gonna get a NullReferenceException was unhandled error
            //{
            //    //if a player has a special defense, it will reduce the amount of damage they take
            //    damageReduction = _specialDefense.CalculateDamageReduction(damage);//current damage parameter they are taking
            //}

            //int totalDamageTaken = damage - damageReduction;

            //NULLDefense class being implemented

            int totalDamageTaken = damage - _specialDefense.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{ Name}'s health has been reduced by {totalDamageTaken} to {Health} ");
        }

    }
}
