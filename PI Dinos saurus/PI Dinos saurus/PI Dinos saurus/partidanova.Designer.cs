namespace PI_Dinos_saurus
{
    partial class partidanova
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            JogadoresPartida = new ListBox();
            label2 = new Label();
            label3 = new Label();
            IdJogadorLabel = new Label();
            SenhaJogador = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 113);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Jogadores da Partida";
            // 
            // JogadoresPartida
            // 
            JogadoresPartida.FormattingEnabled = true;
            JogadoresPartida.Location = new Point(50, 166);
            JogadoresPartida.Name = "JogadoresPartida";
            JogadoresPartida.Size = new Size(150, 104);
            JogadoresPartida.TabIndex = 1;
            JogadoresPartida.SelectedIndexChanged += JogadoresPartida_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 113);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "ID do Jogador";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 223);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 3;
            label3.Text = "Senha do Jogador";
            // 
            // IdJogadorLabel
            // 
            IdJogadorLabel.AutoSize = true;
            IdJogadorLabel.Location = new Point(278, 153);
            IdJogadorLabel.Name = "IdJogadorLabel";
            IdJogadorLabel.Size = new Size(75, 20);
            IdJogadorLabel.TabIndex = 4;
            IdJogadorLabel.Text = "idjogador";
            // 
            // SenhaJogador
            // 
            SenhaJogador.FormattingEnabled = true;
            SenhaJogador.Location = new Point(278, 246);
            SenhaJogador.Name = "SenhaJogador";
            SenhaJogador.Size = new Size(150, 24);
            SenhaJogador.TabIndex = 5;
            SenhaJogador.SelectedIndexChanged += SenhaJogador_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(543, 153);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 6;
            button1.Text = "Iniciar Partida";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // partidanova
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(SenhaJogador);
            Controls.Add(IdJogadorLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(JogadoresPartida);
            Controls.Add(label1);
            Name = "partidanova";
            Text = "partidanova";
            Load += partidanova_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox JogadoresPartida;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox SenhaJogador;
        private Button button1;
        private Label IdJogadorLabel;
    }
}