using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patos2
{
    public abstract class Duck
    {
        public abstract string Display();

        public virtual void Swim()
        {
            Console.WriteLine("O pato está nadando...");
        }
    }
}
