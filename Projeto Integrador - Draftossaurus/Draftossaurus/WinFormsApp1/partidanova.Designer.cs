namespace WinFormsApp1
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
            jogadorespartida = new Label();
            listajogadores = new ListBox();
            label1 = new Label();
            idjogador = new Label();
            label3 = new Label();
            senhajogador = new Label();
            iniciarpartida = new Button();
            SuspendLayout();
            // 
            // jogadorespartida
            // 
            jogadorespartida.AutoSize = true;
            jogadorespartida.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jogadorespartida.Location = new Point(33, 64);
            jogadorespartida.Name = "jogadorespartida";
            jogadorespartida.Size = new Size(243, 31);
            jogadorespartida.TabIndex = 0;
            jogadorespartida.Text = "Jogadores da Partida";
            // 
            // listajogadores
            // 
            listajogadores.FormattingEnabled = true;
            listajogadores.Location = new Point(46, 118);
            listajogadores.Name = "listajogadores";
            listajogadores.Size = new Size(150, 204);
            listajogadores.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 118);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 2;
            label1.Text = "ID do Jogador";
            label1.Click += label1_Click;
            // 
            // idjogador
            // 
            idjogador.AutoSize = true;
            idjogador.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idjogador.Location = new Point(347, 149);
            idjogador.Name = "idjogador";
            idjogador.Size = new Size(55, 23);
            idjogador.TabIndex = 3;
            idjogador.Text = "label2";
            idjogador.Click += idjogador_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(347, 212);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 4;
            label3.Text = "Senha do Jogador";
            // 
            // senhajogador
            // 
            senhajogador.AutoSize = true;
            senhajogador.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            senhajogador.Location = new Point(347, 241);
            senhajogador.Name = "senhajogador";
            senhajogador.Size = new Size(55, 23);
            senhajogador.TabIndex = 5;
            senhajogador.Text = "label4";
            // 
            // iniciarpartida
            // 
            iniciarpartida.Location = new Point(627, 152);
            iniciarpartida.Name = "iniciarpartida";
            iniciarpartida.Size = new Size(98, 79);
            iniciarpartida.TabIndex = 6;
            iniciarpartida.Text = "Iniciar Partida";
            iniciarpartida.UseVisualStyleBackColor = true;
            // 
            // partidanova
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iniciarpartida);
            Controls.Add(senhajogador);
            Controls.Add(label3);
            Controls.Add(idjogador);
            Controls.Add(label1);
            Controls.Add(listajogadores);
            Controls.Add(jogadorespartida);
            Name = "partidanova";
            Text = "partidanova";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label jogadorespartida;
        private ListBox listajogadores;
        private Label label1;
        private Label idjogador;
        private Label label3;
        private Label senhajogador;
        private Button iniciarpartida;
    }
}