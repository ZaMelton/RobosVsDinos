using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursAndRobots
{
    class Weapon
    {
        public string name;
        public int damage;
        public string type;

        public Weapon(string name, int damage, string type)
        {
            this.name = name;
            this.damage = damage;
            this.type = type;
        }
    }
}
