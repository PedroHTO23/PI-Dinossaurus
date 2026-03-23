namespace PI_Dinos_saurus
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
            dinossauros = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 58);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Dinossauros:";
            // 
            // dinossauros
            // 
            dinossauros.FormattingEnabled = true;
            dinossauros.Location = new Point(61, 95);
            dinossauros.Name = "dinossauros";
            dinossauros.Size = new Size(133, 224);
            dinossauros.TabIndex = 1;
            dinossauros.SelectedIndexChanged += dinossauros_SelectedIndexChanged;
            // 
            // partidainiciada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dinossauros);
            Controls.Add(label1);
            Name = "partidainiciada";
            Text = "partidainiciada";
            Load += partidainiciada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox dinossauros;
    }
}