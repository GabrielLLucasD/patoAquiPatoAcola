using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos2
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return "🟥 Sou um pato de cabeça vermelha!";
        }

        public string Fly()
        {
            return "🕊️ Estou voando alto!";
        }

        public string Quack()
        {
            return "🦆 Quack!";
        }
    }
}
