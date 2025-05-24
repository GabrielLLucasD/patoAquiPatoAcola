using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos2
{
    public class RubberDuck : Duck, IQuackable
    {
        public override string Display()
        {
            return "🦆 Sou um pato de borracha 🦆";
        }

        public string Quack()
        {
            return "Squeak!! 🐤";
        }
    }
}
