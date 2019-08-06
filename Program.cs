using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Alex = new Human("Alex", 3, 4, 5);
            Human Mathew = new Human("Mathew", 1, 1, 1);
            Alex.Attack(Mathew);
            System.Console.WriteLine(Mathew.health);
        }
    }
    
    class Human
    {
        //Fields/Properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int health { get; set; }

        public Human(string Name, int Strength = 3, int Intelligence = 3, int Dexterity = 3){
            this.Name = Name;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
            this.Dexterity = Dexterity;
            this.health = 100;
        } 

        public Human(string Name, int Strength, int Intelligence, int Dexterity, int health){
            this.Name = Name;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
            this.Dexterity = Dexterity;
            this.health = health;
        }

        public int Attack(Human Target){
            int damage = this.Strength * 5;
            System.Console.WriteLine($"{this.Name} hit {Target.Name} and did {damage} damage!");
            Target.health = Target.health - damage;
            return Target.health;
        }
    } 
}
