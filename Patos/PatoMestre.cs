using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos2
{
    public class PatoMestre : Duck, IEspecial
    {
        public override string Display()
        {
            return "🧘‍♂️ Sou o Pato Mestre!";
        }

        public string ExecutarEspecial()
        {
            return "🌀 Entrei em estado de meditação absoluta...";
        }
    }
}
