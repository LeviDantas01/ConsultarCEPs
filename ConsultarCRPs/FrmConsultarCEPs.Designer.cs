namespace ConsultarCRPs
{
    partial class FrmConsultarCEPs
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
            label1 = new Label();
            txtCEP = new TextBox();
            Resultado = new GroupBox();
            txtRua = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            txtEstado = new TextBox();
            label2 = new Label();
            btnConsultar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            Resultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "CEP:";
            // 
            // txtCEP
            // 
            txtCEP.BackColor = SystemColors.Info;
            txtCEP.Location = new Point(12, 41);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(142, 27);
            txtCEP.TabIndex = 1;
            // 
            // Resultado
            // 
            Resultado.Controls.Add(txtRua);
            Resultado.Controls.Add(label5);
            Resultado.Controls.Add(txtBairro);
            Resultado.Controls.Add(label4);
            Resultado.Controls.Add(txtCidade);
            Resultado.Controls.Add(label3);
            Resultado.Controls.Add(txtEstado);
            Resultado.Controls.Add(label2);
            Resultado.Location = new Point(12, 80);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(548, 290);
            Resultado.TabIndex = 2;
            Resultado.TabStop = false;
            Resultado.Text = "Dados";
            // 
            // txtRua
            // 
            txtRua.BackColor = Color.LightGray;
            txtRua.Location = new Point(6, 249);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(520, 27);
            txtRua.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 226);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 8;
            label5.Text = "Rua:";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.LightGray;
            txtBairro.Location = new Point(6, 179);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(520, 27);
            txtBairro.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.LightGray;
            txtCidade.Location = new Point(6, 117);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(520, 27);
            txtCidade.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Cidade:";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = Color.LightGray;
            txtEstado.Location = new Point(6, 55);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(520, 27);
            txtEstado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Estado";
            // 
            // btnConsultar
            // 
            btnConsultar.BackgroundImage = ConsultarCEPs.Properties.Resources.busca_cep;
            btnConsultar.BackgroundImageLayout = ImageLayout.Stretch;
            btnConsultar.Location = new Point(373, 18);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(187, 62);
            btnConsultar.TabIndex = 3;
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = ConsultarCEPs.Properties.Resources.limpar;
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(318, 369);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(103, 43);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Image = ConsultarCEPs.Properties.Resources.sair;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(444, 369);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(103, 43);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmConsultarCEPs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 417);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnConsultar);
            Controls.Add(Resultado);
            Controls.Add(txtCEP);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmConsultarCEPs";
            Text = "Consultar CEPs";
            Load += FrmConsultarCEPs_Load;
            Resultado.ResumeLayout(false);
            Resultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCEP;
        private GroupBox Resultado;
        private TextBox txtRua;
        private Label label5;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtCidade;
        private Label label3;
        private TextBox txtEstado;
        private Label label2;
        private Button btnConsultar;
        private Button btnLimpar;
        private Button btnSair;
    }
}
