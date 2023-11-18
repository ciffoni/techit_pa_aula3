//biblioteca do windows
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//nome do projeto
namespace aula3
{
    //classe Usuario publica
    public class ClassUsuario
    {
        //declaração das variaveis 
                public string nome;
        public int idade;

            //metodo construtor
         public ClassUsuario()
        {//inicializa a variavel vazia
            nome = "";
            idade = 0;
        }
        //metodo de cadastro solicita 2 parametros o nome e a idade
        public void cadastrar(String dados,int valor)
        {
            nome= dados;
            idade = valor;

        }
        public void apagar()
        {
            //limpando as informações
            nome = "";
            idade = 0;
        }
        public void listar()
        {
            MessageBox.Show("usuario" + nome + "idade" + idade);
        }

    }
}
