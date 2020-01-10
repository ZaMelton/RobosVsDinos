using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursAndRobots
{
    class Battlefield
    {
        public Fleet robotFleet;
        public Herd dinosaurHerd;
        public Weapon weapon;

        public Battlefield()
        {
            robotFleet = new Fleet();
            dinosaurHerd = new Herd();
        }

        public void simulateBattlefield()
        {
            int roundCount = 1;
            while(dinosaurHerd.dinosaurList.Count != 0 && robotFleet.robotList.Count != 0)
            {
                Console.WriteLine("Round: " + roundCount);
                Console.WriteLine();
                if(robotFleet.robotList.Count != 0)
                {
                    foreach (Dinosaur dino in dinosaurHerd.dinosaurList)
                    {
                        if(robotFleet.robotList.Count != 0)
                        {
                            int targetChoice = dino.ChooseTarget(robotFleet);
                            while (!(robotFleet.robotList.Count >= targetChoice))//if user input is out of index range, this while loop kicks in
                            {
                                targetChoice = dino.ChooseTarget(robotFleet);//asks user to enter a valid input
                            }
                            dino.DinoAttack(robotFleet.robotList[targetChoice - 1]);
                            robotFleet.RemoveDeadRobot(robotFleet.robotList);//if a robot dies in combat, the will remove them from list
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                }

                if(dinosaurHerd.dinosaurList.Count != 0)
                {
                    foreach (Robot robo in robotFleet.robotList)
                    {
                        if (dinosaurHerd.dinosaurList.Count != 0)
                        {
                            int targetChoice = robo.ChooseTarget(dinosaurHerd);
                            while(!(dinosaurHerd.dinosaurList.Count >= targetChoice))//if user input is out of index range, this while loop kicks in
                            {
                                targetChoice = robo.ChooseTarget(dinosaurHerd);//asks user to enter a valid input
                            }
                            
                            int weaponChoice = robo.ChooseWeapon(robotFleet.weaponList);
                            while (!(robotFleet.weaponList.Count >= weaponChoice))//same input validation as above, but for weapon choice
                            {
                                weaponChoice = robo.ChooseWeapon(robotFleet.weaponList);
                            }

                            robo.RobotAttack(dinosaurHerd.dinosaurList[targetChoice - 1], robotFleet.weaponList[weaponChoice - 1]);
                            dinosaurHerd.RemoveDeadDinosaur(dinosaurHerd.dinosaurList);//if a dino dies in combat, the will remove them from list
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                roundCount++;

                Console.Clear();
                if (dinosaurHerd.dinosaurList.Count == 0)
                {
                    Console.WriteLine("ROBOTS WIN!!");
                }
                else
                {
                    Console.WriteLine("DINOSAURS WIN!!");
                }
            }
        }
    }
}
