namespace projeto_teams
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
            combo = new ComboBox();
            txt = new Label();
            quantidade = new Label();
            txttexto = new TextBox();
            txtqtd = new TextBox();
            txttexc = new TextBox();
            txtcombo = new TextBox();
            label1 = new Label();
            indice = new Label();
            inserir = new Button();
            ordenar = new Button();
            remover = new Button();
            dados = new Button();
            SuspendLayout();
            // 
            // combo
            // 
            combo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            combo.FormattingEnabled = true;
            combo.Items.AddRange(new object[] { "titanic", "até o ultimo homem" });
            combo.Location = new Point(138, 221);
            combo.Name = "combo";
            combo.Size = new Size(257, 23);
            combo.TabIndex = 0;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(138, 57);
            txt.Name = "txt";
            txt.Size = new Size(35, 15);
            txt.TabIndex = 1;
            txt.Text = "Texto";
            // 
            // quantidade
            // 
            quantidade.AutoSize = true;
            quantidade.Location = new Point(148, 310);
            quantidade.Name = "quantidade";
            quantidade.Size = new Size(67, 15);
            quantidade.TabIndex = 2;
            quantidade.Text = "qauntidade";
            // 
            // txttexto
            // 
            txttexto.Location = new Point(295, 57);
            txttexto.Name = "txttexto";
            txttexto.Size = new Size(100, 23);
            txttexto.TabIndex = 3;
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(313, 307);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(100, 23);
            txtqtd.TabIndex = 4;
            // 
            // txttexc
            // 
            txttexc.Location = new Point(313, 454);
            txttexc.Name = "txttexc";
            txttexc.Size = new Size(100, 23);
            txttexc.TabIndex = 5;
            // 
            // txtcombo
            // 
            txtcombo.Location = new Point(313, 404);
            txtcombo.Name = "txtcombo";
            txtcombo.Size = new Size(100, 23);
            txtcombo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 462);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 7;
            label1.Text = "Texto do Combo";
            // 
            // indice
            // 
            indice.AutoSize = true;
            indice.Location = new Point(138, 412);
            indice.Name = "indice";
            indice.Size = new Size(99, 15);
            indice.TabIndex = 8;
            indice.Text = "indice do Combo";
            // 
            // inserir
            // 
            inserir.Location = new Point(148, 153);
            inserir.Name = "inserir";
            inserir.Size = new Size(114, 23);
            inserir.TabIndex = 9;
            inserir.Text = "inserir no combo";
            inserir.UseVisualStyleBackColor = true;
            inserir.Click += inserir_Click;
            // 
            // ordenar
            // 
            ordenar.Location = new Point(295, 153);
            ordenar.Name = "ordenar";
            ordenar.Size = new Size(100, 23);
            ordenar.TabIndex = 10;
            ordenar.Text = "ondenar combo";
            ordenar.UseVisualStyleBackColor = true;
            ordenar.Click += ordenar_Click;
            // 
            // remover
            // 
            remover.Location = new Point(231, 263);
            remover.Name = "remover";
            remover.Size = new Size(75, 23);
            remover.TabIndex = 11;
            remover.Text = "remover";
            remover.UseVisualStyleBackColor = true;
            remover.Click += remover_Click;
            // 
            // dados
            // 
            dados.Location = new Point(217, 361);
            dados.Name = "dados";
            dados.Size = new Size(101, 23);
            dados.TabIndex = 12;
            dados.Text = "exibir dados";
            dados.UseVisualStyleBackColor = true;
            dados.Click += dados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 514);
            Controls.Add(dados);
            Controls.Add(remover);
            Controls.Add(ordenar);
            Controls.Add(inserir);
            Controls.Add(indice);
            Controls.Add(label1);
            Controls.Add(txtcombo);
            Controls.Add(txttexc);
            Controls.Add(txtqtd);
            Controls.Add(txttexto);
            Controls.Add(quantidade);
            Controls.Add(txt);
            Controls.Add(combo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo;
        private Label txt;
        private Label quantidade;
        private TextBox txttexto;
        private TextBox txtqtd;
        private TextBox txttexc;
        private TextBox txtcombo;
        private Label label1;
        private Label indice;
        private Button inserir;
        private Button ordenar;
        private Button remover;
        private Button dados;
    }
}
