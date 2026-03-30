namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            nomegrupo = new TextBox();
            entralobby = new Button();
            versaodll = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(290, 85);
            label1.Name = "label1";
            label1.Size = new Size(200, 38);
            label1.TabIndex = 0;
            label1.Text = "Draftossaurus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 140);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Grupo:";
            // 
            // nomegrupo
            // 
            nomegrupo.Location = new Point(323, 179);
            nomegrupo.Name = "nomegrupo";
            nomegrupo.Size = new Size(125, 27);
            nomegrupo.TabIndex = 2;
            nomegrupo.TextChanged += nomegrupo_TextChanged;
            // 
            // entralobby
            // 
            entralobby.Location = new Point(340, 261);
            entralobby.Name = "entralobby";
            entralobby.Size = new Size(92, 90);
            entralobby.TabIndex = 3;
            entralobby.Text = "Entrar no Lobby";
            entralobby.UseVisualStyleBackColor = true;
            entralobby.Click += entralobby_Click;
            // 
            // versaodll
            // 
            versaodll.AutoSize = true;
            versaodll.Location = new Point(30, 403);
            versaodll.Name = "versaodll";
            versaodll.Size = new Size(82, 20);
            versaodll.TabIndex = 4;
            versaodll.Text = "Versão DLL";
            versaodll.Click += versaodll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(versaodll);
            Controls.Add(entralobby);
            Controls.Add(nomegrupo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox nomegrupo;
        private Button entralobby;
        private Label versaodll;
    }
}
