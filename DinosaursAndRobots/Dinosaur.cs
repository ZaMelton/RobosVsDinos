using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursAndRobots
{
    class Dinosaur
    {
        public string type;
        public int health;
        public int stamina;
        public int attackPower;

        public Dinosaur(string type, int health, int stamina, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.stamina = stamina;
            this.attackPower = attackPower;
        }

        public void ChooseTarget(Fleet robotFleet)
        {
            Console.WriteLine("Choose " + type + "'s target: ");
            foreach (Robot robot in robotFleet.robotList)
            {
                Console.WriteLine(robot.name);
            }

            string target = Console.ReadLine();
            
            foreach(Robot robot in robotFleet.robotList)
            {
                if(target.ToLower() == robot.name.ToLower())
                {
                    DinoAttack(robot);
                    break;
                }
            }
        }

        public void DinoAttack(Robot robot)
        {
            Random random = new Random();
            int chanceForHit = random.Next(1, 10);
            if(chanceForHit == 1)
            {
                Console.WriteLine(type + " missed their attack!");
            }
            else
            {
                robot.health -= attackPower;
                Console.WriteLine(type + " attacked " + robot.name + " for " + attackPower + " damage.");
                Console.WriteLine(robot.name + " has " + robot.health + " health left.");
            }
        }

    }

}
