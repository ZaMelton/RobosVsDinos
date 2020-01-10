using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursAndRobots
{
    class Fleet
    {
        
        public List<Robot> robotList;
        int totalHealth;
        Weapon weapon;

        public Fleet()
        {
            robotList = new List<Robot>();
            MakeFleet();
        }

        public void MakeFleet()
        {
            Robot walle = new Robot("WALL-E", 100, 10, 50);
            Robot pathfinder = new Robot("Pathfinder", 100, 10, 80);
            Robot ig11 = new Robot("IG-11", 100, 10, 75);
            robotList.Add(walle);
            robotList.Add(pathfinder);
            robotList.Add(ig11);
        }

        public void RemoveDeadRobot(List<Robot> robotList)
        {
            foreach (Robot robo in robotList)
            {
                if (robo.health <= 0)
                {
                    robotList.Remove(robo);
                    break;
                }
            }
        }

        //Weapon sword = new Weapon("Rusty Blade", 10, "sword");
        //Weapon bow = new Weapon("Rusty Blade", 20, "bow");
        //Weapon claymore = new Weapon("Bringer of Justice", 50, "longsword");
    }
}
