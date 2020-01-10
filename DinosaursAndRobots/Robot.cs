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

        public int ChooseTarget(Herd dinosaurHerd)
        {
            Console.WriteLine("Choose " + name + "'s target: ");
            int targetNum = 1;
            //displays targets
            foreach (Dinosaur dinosaur in dinosaurHerd.dinosaurList)
            {
                Console.WriteLine(targetNum + ") " + dinosaur.type + " (" + dinosaur.health + " HP)");
                targetNum++;
            }

            //Input validation
            bool validInput = int.TryParse(Console.ReadLine(), out int targetChoice);

            while (!(validInput))
            {
                Console.WriteLine("Invalid target, try again..\nPlease enter a number according to target.");
                validInput = int.TryParse(Console.ReadLine(), out targetChoice);
            }

            return targetChoice;
        }

        public int ChooseWeapon(List<Weapon> weaponList)
        {
            Console.WriteLine("Please choose a weapon for " + name + " to use.");
            int weaponNum = 1;
            //displays weapons
            foreach(Weapon weapon in weaponList)
            {
                Console.WriteLine(weaponNum + ") " + weapon.name);
                weaponNum++;
            }

            //Input validation
            bool validInput = int.TryParse(Console.ReadLine(), out int weaponChoice);

            while (!(validInput))
            {
                Console.WriteLine("Invalid target, try again..\nPlease enter a number according to target.");
                validInput = int.TryParse(Console.ReadLine(), out weaponChoice);
            }

            return weaponChoice;
        }

        public void RobotAttack(Dinosaur dinosaur, Weapon weaponChoice)
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
                //assigns the proper weapon damage to attack power
                attackPower = weaponChoice.damage;

                //if blad of restoration is chosen, heals user
                if(weaponChoice.name == "Blade of Restoration")
                {
                    health += weaponChoice.damage;//heals user for damage dealt
                    Console.WriteLine();
                    Console.WriteLine(weaponChoice.name + "'s healing powers restored " + name + "'s health by " + weaponChoice.damage + "HP!");
                    Console.WriteLine(name + "'s HP is now " + health);
                }

                //if its pathfinders turn and the user selects the Kraber, pathfinder deals bonus damage
                if (weaponChoice.name == "Kraber" && name == "Pathfinder")
                {
                    int pathfinderKraberDamage = 125; 
                    attackPower = pathfinderKraberDamage;
                    Console.WriteLine();
                    Console.WriteLine("Due to Pathfinder's exceptional skills with the Kraber sniper rifle, he does bonus damage!!");
                }

                dinosaur.health -= attackPower;
                Console.WriteLine();
                Console.WriteLine(name + " attacked " + dinosaur.type + " with the " + weaponChoice.name + " for " + attackPower + " damage.");

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
