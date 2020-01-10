using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursAndRobots
{
    class Battlefield
    {
        Fleet robotFleet;
        Herd dinosaurHerd;
        Weapon weapon;

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
                            while (!(robotFleet.robotList.Count >= targetChoice))
                            {
                                targetChoice = dino.ChooseTarget(robotFleet);
                            }
                            dino.DinoAttack(robotFleet.robotList[targetChoice - 1]);
                            robotFleet.RemoveDeadRobot(robotFleet.robotList);
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
                            while(!(dinosaurHerd.dinosaurList.Count >= targetChoice))
                            {
                                targetChoice = robo.ChooseTarget(dinosaurHerd);
                            }
                            robo.RobotAttack(dinosaurHerd.dinosaurList[targetChoice - 1]);
                            dinosaurHerd.RemoveDeadDinosaur(dinosaurHerd.dinosaurList);
                        }

                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                roundCount++;

                /////////////////////////////ORIGINAL SEQUENCE///////////////////////////////
                //dinosaurHerd.dinosaurList[0].ChooseTarget(robotFleet);
                //robotFleet.CheckFleetCount(robotFleet.robotList);
                //robotFleet.robotList[0].ChooseTarget(dinosaurHerd);
                //dinosaurHerd.CheckHerdCount(dinosaurHerd.dinosaurList);
                //Console.ReadLine();
                //Console.Clear();
                /////////////////////////////ORIGINAL SEQUENCE///////////////////////////////
            }
        }
    }
}
