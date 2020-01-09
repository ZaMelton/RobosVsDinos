using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursAndRobots
{
    class Herd
    {
        public List<Dinosaur> dinosaurList;

        public Herd()
        {
            dinosaurList = new List<Dinosaur>();
            MakeHerd();
        }

        public void MakeHerd()
        {
            Dinosaur tRex = new Dinosaur("T-Rex", 150, 80, 50);
            Dinosaur raptor = new Dinosaur("Raptor", 100, 150, 20);
            Dinosaur longNeck = new Dinosaur("Long Neck", 500, 100, 100);
            dinosaurList.Add(tRex);
            dinosaurList.Add(raptor);
            dinosaurList.Add(longNeck);
        }

        public int CheckHerdCount(List<Dinosaur> dinosaurList)
        {
            foreach(Dinosaur dinosaur in dinosaurList)
            {
                if (dinosaur.health == 0)
                {
                    RemoveDeadDinosaur(dinosaur);
                    break;
                }
            }
            if (dinosaurList.Count() == 0)
            {
                return 0;
            }
            return 1;
        }

        public void RemoveDeadDinosaur(Dinosaur dinosaur)
        {
            dinosaurList.Remove(dinosaur);
        }
    }
}
