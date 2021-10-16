using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplasEscolhasApp
{
    public abstract class Animal
    {
        private string nome;
        private string tipo;

        public virtual string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getTipo()
        {
            return this.tipo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string verificarTipoAnimal(string tipoAnimal)
        {
            if(tipoAnimal != "cachorro" || tipoAnimal != "gato" || tipoAnimal != "peixe")
            {
                tipoAnimal = "peixe";

                return tipoAnimal;
            }
            else {
                return tipoAnimal;
            }
        }
    }
}
