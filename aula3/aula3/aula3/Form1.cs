namespace aula3
{
    public partial class Form1 : Form
    {
        //classe instanciada é publico em todo o forms
        ClassUsuario usuario = new ClassUsuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //chama a classe usuario defino um nome para ela
           // ClassUsuario usuario = new ClassUsuario();
            //popular os atributos da classe
            // usuario.nome = txtNome.Text; 
            // usuario.idade = Convert.ToInt32(txtIdade.Text);
            
            //tratando o campo idade para garantir que seja preenchido
            if (string.IsNullOrEmpty(txtIdade.Text))
            {//atribuir zero no text
                MessageBox.Show("Campo idade não pode ser vazio!");
                txtIdade.Focus();
                return;//garente o retorno da mensagem
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo nome está vazio!");
                txtNome.Focus();//pega o cursor
                return;//pausa a mensagem
            }
            else
            {//chamar o metodo cadastrar da classe usuario
                 usuario.cadastrar(txtNome.Text, Convert.ToInt32(txtIdade.Text));
                MessageBox.Show("Ola usuário: "+ usuario.nome 
                + "\n" + "sua idade: " + usuario.idade);
                //adiciona o item ao listar usuario
                listausuario.Items.Add(txtNome.Text);
                listausuario.Items.Add(txtIdade.Text);
                txtIdade.Clear();
                txtNome.Clear();

            }
           
        }

        private void btnOrientacao_Click(object sender, EventArgs e)
        {
            //instancio as classes
            // instanciando o filho
            veiculo a = new Carro();
            veiculo b = new aviao();
            //Carro c= new Carro();
            //chmando o metodo locomover da classe veiculo
            a.locomover();
            b.locomover();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
           // ClassUsuario usuario = new ClassUsuario();
            usuario.apagar();
            txtIdade.Clear();//limpar as informações do text
            txtNome.Clear(); //limpar o nome
            MessageBox.Show("dados apagados com sucesso");
            txtNome.Focus();//recebe o cursor do mouse
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
           
            usuario.listar();
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        { //tecla enter
            
            if(e.KeyChar == 13)
            {
               btnCadastro_Click(sender, e);
            }
        }

        private void listausuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seleciona o item da lista para exebir no nome e idade
            txtNome.Text = listausuario.SelectedItems[0].Text ;
          //  txtIdade.Text=listausuario.SelectedItems[1].Text ;
        }
    }
}