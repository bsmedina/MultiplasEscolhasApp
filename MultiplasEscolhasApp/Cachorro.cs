using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplasEscolhasApp
{
    public class Cachorro : Animal
    {

        public Cachorro(string nome, string tipo)
        {
            this.setNome(nome);
            this.setTipo(tipo);
        }

    }
}
