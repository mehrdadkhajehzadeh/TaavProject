using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    public class Hero : Charecter
    {
        public int Speed { get; set; }
        public Hero(string name, int power, int health, int speed) : base(name, power, health)
        {
            Speed = speed;
        }

    }
}
