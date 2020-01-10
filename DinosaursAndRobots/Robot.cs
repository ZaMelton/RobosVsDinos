using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursAndRobots
{
    class Robot
    { 
        public string name;
        public int health;
        public int powerLevel;
        public int attackPower;
        public Weapon weapon;

        public Robot(string name, int health, int powerLevel, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;
        }

        public void ChooseTarget(Herd dinosaurHerd)
        {
            Console.WriteLine("Choose " + name + "'s target: ");
            foreach (Dinosaur dinosaur in dinosaurHerd.dinosaurList)
            {
                Console.WriteLine(dinosaur.type + " (" + dinosaur.health + " HP)");
            }

            string target = Console.ReadLine();

            foreach (Dinosaur dinosaur in dinosaurHerd.dinosaurList)
            {
                if (target.ToLower() == dinosaur.type.ToLower())
                {
                    RobotAttack(dinosaur);
                    break;
                }
            }
        }
        public void RobotAttack(Dinosaur dinosaur)
        {
            Random random = new Random();
            int chanceForHit = random.Next(1, 11);

            if(chanceForHit == 1)
            {
                Console.WriteLine(name + " missed their attack!");
                Console.WriteLine();
            }
            else
            {
                dinosaur.health -= attackPower;
                Console.WriteLine();
                Console.WriteLine(name + " attacked " + dinosaur.type + " for " + attackPower + " damage.");

                if(dinosaur.health < 0)
                {
                    dinosaur.health = 0;
                }
                Console.WriteLine(dinosaur.type + " has " + dinosaur.health + " health left.");
                Console.WriteLine();
            }
        }
    }
}
