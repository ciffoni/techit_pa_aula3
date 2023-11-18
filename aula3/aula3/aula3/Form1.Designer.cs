namespace aula3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnOrientacao = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.listausuario = new System.Windows.Forms.ListView();
            this.btnExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(452, 190);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(195, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(196, 57);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 23);
            this.txtIdade.TabIndex = 4;
            this.txtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdade_KeyPress);
            // 
            // btnOrientacao
            // 
            this.btnOrientacao.Location = new System.Drawing.Point(452, 247);
            this.btnOrientacao.Name = "btnOrientacao";
            this.btnOrientacao.Size = new System.Drawing.Size(75, 23);
            this.btnOrientacao.TabIndex = 5;
            this.btnOrientacao.Text = "orientação";
            this.btnOrientacao.UseVisualStyleBackColor = true;
            this.btnOrientacao.Click += new System.EventHandler(this.btnOrientacao_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(569, 194);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // listausuario
            // 
            this.listausuario.Location = new System.Drawing.Point(67, 149);
            this.listausuario.Name = "listausuario";
            this.listausuario.Size = new System.Drawing.Size(228, 97);
            this.listausuario.TabIndex = 7;
            this.listausuario.UseCompatibleStateImageBehavior = false;
            this.listausuario.SelectedIndexChanged += new System.EventHandler(this.listausuario_SelectedIndexChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(573, 246);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 8;
            this.btnExibir.Text = "Exibir registro";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.listausuario);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnOrientacao);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastro;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtIdade;
        private Button btnOrientacao;
        private Button btnApagar;
        private ListView listausuario;
        private Button btnExibir;
    }
}