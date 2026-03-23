namespace PI_Dinos_saurus
{
    partial class Lobby
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
            button1 = new Button();
            Partidas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Players = new ListBox();
            NomePartida = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(181, 55);
            button1.Name = "button1";
            button1.Size = new Size(80, 26);
            button1.TabIndex = 0;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Partidas
            // 
            Partidas.FormattingEnabled = true;
            Partidas.Location = new Point(50, 137);
            Partidas.Name = "Partidas";
            Partidas.Size = new Size(150, 164);
            Partidas.TabIndex = 1;
            Partidas.SelectedIndexChanged += Partidas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 146);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "ID Partida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 204);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome da Partida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 267);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 4;
            label3.Text = "Data da Partida";
            // 
            // Players
            // 
            Players.FormattingEnabled = true;
            Players.Location = new Point(378, 137);
            Players.Name = "Players";
            Players.Size = new Size(114, 164);
            Players.TabIndex = 5;
            // 
            // NomePartida
            // 
            NomePartida.Location = new Point(602, 137);
            NomePartida.Name = "NomePartida";
            NomePartida.Size = new Size(106, 27);
            NomePartida.TabIndex = 6;
            NomePartida.TextChanged += NomePartida_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(602, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(602, 114);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 8;
            label4.Text = "Nome da Partida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 181);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Grupo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(602, 237);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 10;
            label6.Text = "Senha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(604, 207);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 11;
            label7.Text = "label4";
            // 
            // button3
            // 
            button3.Location = new Point(602, 312);
            button3.Name = "button3";
            button3.Size = new Size(154, 29);
            button3.TabIndex = 12;
            button3.Text = "Criar Partida";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(NomePartida);
            Controls.Add(Players);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Partidas);
            Controls.Add(button1);
            Name = "Lobby";
            Text = "Lobby";
            Load += Lobby_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox Partidas;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox Players;
        private TextBox NomePartida;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
    }
}