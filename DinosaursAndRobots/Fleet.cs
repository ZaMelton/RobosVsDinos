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
        int maxNumOfRobots = 3;

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
            //////////////////////////////////////Trying to let user choose robot team////////////////////////////////////////
            //Robot walle = new Robot("WALL-E", 100, 10, 50);
            //Robot pathfinder = new Robot("Pathfinder", 100, 10, 80);
            //Robot ig11 = new Robot("IG-11", 100, 10, 75);
            //Robot c3po = new Robot("C-3PO", 25, 10, 2);
            //Robot goddard = new Robot("Goddard", 50, 10, 215);
            //Robot starscream = new Robot("Starscream", 300, 10, 90);

            //Console.WriteLine("What robots do you want on your team?");
            //Console.WriteLine();
            //Console.WriteLine(walle.name + "\n" + pathfinder.name + "\n" + ig11.name + "\n" + c3po.name + "\n" + goddard.name + "\n" + starscream.name);
            //Console.WriteLine();
            //for (int i = 0; i < maxNumOfRobots; i++)
            //{
            //    Console.WriteLine("Please type the name of the robot you would like to add (case doesn't matter)");


            //    string robotChoice = Console.ReadLine().ToLower();

            //    foreach(Robot robo in robotList)
            //    {
            //        if (robotChoice == robo.name)
            //        {
            //            robotList.Add(robo);
            //        }
            //    }
            //}

            ///////////////////////////////////////Original make fleet/////////////////////////////////////////
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
