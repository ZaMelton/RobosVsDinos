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

        public int CheckFleetCount(List<Robot> robotList)
        {
            foreach(Robot robot in robotList)
            {
                if (robot.health <= 0)
                {
                    RemoveDeadRobot(robot);
                    break;
                }
            }
            if(robotList.Count() == 0)
            {
                return 0;
            }
            return robotList.Count();
        }

        public void RemoveDeadRobot(Robot robot)
        {
            robotList.Remove(robot);
        }

        //Weapon sword = new Weapon("Rusty Blade", 10, "sword");
        //Weapon bow = new Weapon("Rusty Blade", 20, "bow");
        //Weapon claymore = new Weapon("Bringer of Justice", 50, "longsword");
    }
}
