using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos2
{
    public class PatoChef : Duck, IQuackable, IEspecial
    {
        public override string Display()
        {
            return "👨‍🍳 Sou o Pato Chef!";
        }

        public string Quack()
        {
            return "🦆 Quack do chef!";
        }

        public string ExecutarEspecial()
        {
            return "🎂 Preparei um bolo delicioso!";
        }
    }
}
