using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    //classi veiculo
    public class veiculo
    {
        // seus variaveis(atributos)
        public string marca;
        private string chassi;
        protected string placa;
        //metodo construtor
        public veiculo()
        {
            marca = "";
            chassi = "";
            placa = "";
        }
        //metodo da classe
        public virtual void locomover()
        {

        }
    }
}
