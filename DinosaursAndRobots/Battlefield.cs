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
            while(dinosaurHerd.CheckHerdCount(dinosaurHerd.dinosaurList) != 0 || robotFleet.CheckFleetCount(robotFleet.robotList) != 0)
            {
                //for each loop here to choose which one will attack???
                dinosaurHerd.dinosaurList[0].ChooseTarget(robotFleet);
                robotFleet.CheckFleetCount(robotFleet.robotList);
                robotFleet.robotList[0].ChooseTarget(dinosaurHerd);
                dinosaurHerd.CheckHerdCount(dinosaurHerd.dinosaurList);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
