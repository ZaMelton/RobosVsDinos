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
            //unecessary stuff in while loop???
            //could just use dinosaurHerd.dinosaurList.Count()???
            //Could I then remove the method???
            while(dinosaurHerd.CheckHerdCount(dinosaurHerd.dinosaurList) != 0 && robotFleet.CheckFleetCount(robotFleet.robotList) != 0)
            {
                if(dinosaurHerd.CheckHerdCount(dinosaurHerd.dinosaurList) != 0)
                {
                    foreach (Dinosaur dino in dinosaurHerd.dinosaurList)
                    {
                        dino.ChooseTarget(robotFleet);
                        robotFleet.CheckFleetCount(robotFleet.robotList);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }

                if(robotFleet.CheckFleetCount(robotFleet.robotList) != 0)
                {
                    foreach (Robot robo in robotFleet.robotList)
                    {
                        robo.ChooseTarget(dinosaurHerd);
                        dinosaurHerd.CheckHerdCount(dinosaurHerd.dinosaurList);
                    }
                    Console.ReadLine();
                    Console.Clear();
                }


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
