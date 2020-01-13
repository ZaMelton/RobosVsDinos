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
        public List<Weapon> weaponList;

        public Fleet()
        {
            robotList = new List<Robot>();
            weaponList = new List<Weapon>();
            MakeFleet();
            MakeWeapons();
        }

        public void MakeWeapons()
        {
            Weapon sword = new Weapon("Blade of Restoration", 30, "sword");
            Weapon bow = new Weapon("Bow of Bowness", 50, "bow");
            Weapon claymore = new Weapon("Bringer of Justice", 85, "longsword");
            Weapon rifle = new Weapon("Kraber", 50, "rifle");
            Weapon fist = new Weapon("Fist", 15, "unarmed");
            weaponList.Add(sword);
            weaponList.Add(bow);
            weaponList.Add(claymore);
            weaponList.Add(rifle);
            weaponList.Add(fist);
        }
        public void MakeFleet()
        {
            Robot walle = new Robot("WALL-E", 75, 10, 50);
            Robot pathfinder = new Robot("Pathfinder", 120, 10, 80);
            Robot ig11 = new Robot("IG-11", 120, 10, 75);
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
    }
}
