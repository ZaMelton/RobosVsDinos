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
        public AttackType attackType;

        public Dinosaur(string type, int health, int stamina, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.stamina = stamina;
            this.attackPower = attackPower;
        }

        public int ChooseTarget(Fleet robotFleet)
        {
            Console.WriteLine("Choose " + type + "'s target: ");
            int targetNum = 1;
            //display targets and their health
            foreach (Robot robot in robotFleet.robotList)
            {
                Console.WriteLine(targetNum + ") " + robot.name + " (" + robot.health + " HP)");
                targetNum++;
            }
            
            //Asks for user input and immediately tries to parse it to an int
            bool validInput = int.TryParse(Console.ReadLine(), out int targetChoice);

            //if the parse fails, the while loop with run and ask user to try again
            while (!(validInput))
            {
                Console.WriteLine("Invalid target, try again..\nPlease enter a number according to target.");
                validInput = int.TryParse(Console.ReadLine(), out targetChoice);
            }

            return targetChoice;
        }

        public void DinoAttack(Robot robot)
        {
            Random random = new Random();
            int chanceForHit;

            if (type == "Long Neck")
            {
                chanceForHit = random.Next(1, 4);//Makes long necks chance for hit to be lower
            }
            else
            {
                chanceForHit = random.Next(1, 6);//default chance to hit for all other dinos
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
                    robot.health = 0;//stops negative health from being displayed
                }
                Console.WriteLine(robot.name + " has " + robot.health + " health left.");
                Console.WriteLine();
            }
        }

    }

}
