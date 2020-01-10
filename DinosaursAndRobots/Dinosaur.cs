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
                Console.WriteLine(robot.name + " (" + robot.health + " HP)");
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
            int chanceForHit;
            if (type == "Long Neck")
            {
                chanceForHit = random.Next(1, 4);
            }
            else
            {
                chanceForHit = random.Next(1, 6);
            }
            if(chanceForHit == 1)
            {
                Console.WriteLine(type + " missed their attack!");
                Console.WriteLine();
            }
            else
            {
                robot.health -= attackPower;
                Console.WriteLine();
                Console.WriteLine(type + " attacked " + robot.name + " for " + attackPower + " damage.");
                if(robot.health < 0)
                {
                    robot.health = 0;
                }
                Console.WriteLine(robot.name + " has " + robot.health + " health left.");
                Console.WriteLine();
            }
        }

    }

}
