using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplasEscolhasApp
{
    class Peixe : Animal
    {

        public Peixe(string nome, string tipo)
        {
            this.setNome(nome);
            this.setTipo(tipo);
        }
    }
}
