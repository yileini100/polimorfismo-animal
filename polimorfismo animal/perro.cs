using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_animal
{
    internal class perro:animal
    {
        public override string HacerSonido()
        {
            return "Woof";
        }

    }
}
