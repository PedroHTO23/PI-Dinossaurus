namespace WinFormsApp1
{
    partial class lobby
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
            listarpartidas = new Button();
            listaplayers = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grupo = new Label();
            nomedapartida = new TextBox();
            senhapartida = new TextBox();
            datagridpartidas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagridpartidas).BeginInit();
            SuspendLayout();
            // 
            // listarpartidas
            // 
            listarpartidas.Location = new Point(677, 349);
            listarpartidas.Name = "listarpartidas";
            listarpartidas.Size = new Size(94, 50);
            listarpartidas.TabIndex = 1;
            listarpartidas.Text = "Conectar";
            listarpartidas.UseVisualStyleBackColor = true;
            // 
            // listaplayers
            // 
            listaplayers.FormattingEnabled = true;
            listaplayers.Location = new Point(464, 109);
            listaplayers.Name = "listaplayers";
            listaplayers.Size = new Size(150, 224);
            listaplayers.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(650, 109);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome da Partida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 187);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Grupo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 253);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // grupo
            // 
            grupo.AutoSize = true;
            grupo.Location = new Point(650, 207);
            grupo.Name = "grupo";
            grupo.Size = new Size(50, 20);
            grupo.TabIndex = 9;
            grupo.Text = "label4";
            grupo.Click += grupo_Click;
            // 
            // nomedapartida
            // 
            nomedapartida.Location = new Point(650, 132);
            nomedapartida.Name = "nomedapartida";
            nomedapartida.Size = new Size(88, 27);
            nomedapartida.TabIndex = 10;
            nomedapartida.TextChanged += nomedapartida_TextChanged;
            // 
            // senhapartida
            // 
            senhapartida.Location = new Point(650, 274);
            senhapartida.Name = "senhapartida";
            senhapartida.Size = new Size(88, 27);
            senhapartida.TabIndex = 11;
            senhapartida.TextChanged += senhapartida_TextChanged_1;
            // 
            // datagridpartidas
            // 
            datagridpartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridpartidas.Location = new Point(29, 51);
            datagridpartidas.Name = "datagridpartidas";
            datagridpartidas.RowHeadersWidth = 51;
            datagridpartidas.Size = new Size(394, 348);
            datagridpartidas.TabIndex = 12;
            // 
            // lobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datagridpartidas);
            Controls.Add(senhapartida);
            Controls.Add(nomedapartida);
            Controls.Add(grupo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listaplayers);
            Controls.Add(listarpartidas);
            Name = "lobby";
            Text = "lobby";
            ((System.ComponentModel.ISupportInitialize)datagridpartidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button listarpartidas;
        private ListBox listaplayers;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label grupo;
        private TextBox nomedapartida;
        private TextBox senhapartida;
        private DataGridView datagridpartidas;
    }
}