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
            Dinosaur raptor = new Dinosaur("Raptor", 120, 150, 30);
            Dinosaur longNeck = new Dinosaur("Long Neck", 300, 100, 90);
            dinosaurList.Add(tRex);
            dinosaurList.Add(raptor);
            dinosaurList.Add(longNeck);
        }

        public void RemoveDeadDinosaur(List<Dinosaur> dinosaurList)
        {
            foreach (Dinosaur dinosaur in dinosaurList)
            {
                if (dinosaur.health <= 0)
                {
                    dinosaurList.Remove(dinosaur);
                    break;
                }
            }
        }
    }
}
