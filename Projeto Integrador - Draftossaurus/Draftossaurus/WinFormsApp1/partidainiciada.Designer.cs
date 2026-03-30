namespace WinFormsApp1
{
    partial class partidainiciada
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            maoatual = new ListBox();
            label7 = new Label();
            dados = new Button();
            proxturno = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 0;
            label1.Text = "Jogador que começará o turno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 70);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(733, 38);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Turno Atual:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(828, 38);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(757, 277);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "Valor Sorteado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(757, 306);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // maoatual
            // 
            maoatual.FormattingEnabled = true;
            maoatual.Location = new Point(25, 278);
            maoatual.Name = "maoatual";
            maoatual.Size = new Size(123, 124);
            maoatual.TabIndex = 6;
            maoatual.SelectedIndexChanged += maoatual_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 246);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 7;
            label7.Text = "Mão Atual:";
            // 
            // dados
            // 
            dados.Location = new Point(752, 216);
            dados.Name = "dados";
            dados.Size = new Size(115, 47);
            dados.TabIndex = 8;
            dados.Text = "Rolar Dados";
            dados.UseVisualStyleBackColor = true;
            dados.Click += dados_Click;
            // 
            // proxturno
            // 
            proxturno.Location = new Point(757, 374);
            proxturno.Name = "proxturno";
            proxturno.Size = new Size(136, 45);
            proxturno.TabIndex = 9;
            proxturno.Text = "Próximo Turno:";
            proxturno.UseVisualStyleBackColor = true;
            // 
            // partidainiciada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 450);
            Controls.Add(proxturno);
            Controls.Add(dados);
            Controls.Add(label7);
            Controls.Add(maoatual);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "partidainiciada";
            Text = "partidainiciada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox maoatual;
        private Label label7;
        private Button dados;
        private Button proxturno;
    }
}