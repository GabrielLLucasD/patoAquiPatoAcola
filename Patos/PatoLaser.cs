using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos2
{
    public class PatoLaser : Duck, IFlyable, IEspecial
    {
        public override string Display()
        {
            return "⚡ Sou o Pato Laser!";
        }

        public string Fly()
        {
            return "🚀 Voando com velocidade supersônica!";
        }

        public string ExecutarEspecial()
        {
            return "💥 Disparei um super raio!";
        }
    }
}
