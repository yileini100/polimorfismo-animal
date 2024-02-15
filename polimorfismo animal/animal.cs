using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_animal
{
    public class animal
    {
        public virtual string HacerSonido()
        {
            return "Sonido genérico de animal";
        }

    }
}
