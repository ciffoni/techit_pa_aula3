using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    //herdando as informações do veiculo
    public class Carro:veiculo
    {
        //crio seu construtor
        public Carro()
        {

        }
        //metodo herdado da classe veiculo
        //alteração do conteudo do metodo locomover
        public override void locomover()
        {
            MessageBox.Show("Acelerar");
        }
    }
    }

