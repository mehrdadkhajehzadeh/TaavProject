using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    public class Charecter
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Health { get; set; }
        public Alivestate Alivestate { get; set; }

        public Charecter(string name, int power, int health)
        {
            Name = name;
            Power = power;
            Health = health;
            Alivestate = Alivestate.Alive;
        }
        public void BeAttached(int power)
        {
            Health -= power;
            if (Health <= 0)
            {
                Alivestate = Alivestate.Dead;
                Console.WriteLine("hahaha" + " " + Alivestate);
            }
            else
            {
                Console.WriteLine($"{Name} fanaly {Health}");
            }
        }


    }
    public enum Alivestate
    {
        Dead,
        Alive

    }
}
