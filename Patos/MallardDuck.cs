using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos2
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return "🐤 Sou um pato selvagem!";
        }

        public string Fly()
        {
            return "🕊️ Estou voando!";
        }

        public string Quack()
        {
            return "🦆 Quack, quack!!";
        }
    }
}
