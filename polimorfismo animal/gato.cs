using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_animal
{
    public class gato:animal
    {
        public override string HacerSonido()
        {
            return "Meow";
        }

    }
}
