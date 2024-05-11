using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg_companion.GenerateEnemy;

namespace rpg_companion.Enemy.GenEnemy
{
    public class GenNpc
    {
        public static void genHuman(string name)
        {
            Biological Enemy = new Biological(name);
            Console.WriteLine();
            Console.WriteLine("Name: " + Enemy.name);
            Console.WriteLine("Type: Biological");
            Console.WriteLine("HP: " + Enemy.hp);
            Console.WriteLine("Race: " + Enemy.race);
            Console.WriteLine("Sex: " + Enemy.gender);
            Console.WriteLine("Weapon: " + Enemy.weapon);
            Console.WriteLine("Screen: " + Enemy.screen);
            Console.WriteLine("Suit: " + Enemy.suit);
            Console.WriteLine();
        }

        public static void genRobot(string name)
        {
            Robot Enemy = new Robot(name);
            Console.WriteLine();
            Console.WriteLine("Name: " + Enemy.name);
            Console.WriteLine("Type: Robot");
            Console.WriteLine("HP: " + Enemy.hp);
            Console.WriteLine("Robot Type: " + Enemy.robotType);
            Console.WriteLine("Program: " + Enemy.program);
            Console.WriteLine("Body: " + Enemy.body);
            Console.WriteLine("Movement: " + Enemy.movement);

            Console.WriteLine();

        }

        public static void genCreature(string name)
        {
            Creature Enemy = new Creature(name);
            Console.WriteLine();
            Console.WriteLine("Name: " + Enemy.name);
            Console.WriteLine("Type: Creature");
            Console.WriteLine("HP: " + Enemy.hp);
            Console.WriteLine("Creature Type: " + Enemy.creatureType);
            Console.WriteLine();

        }
    }
}