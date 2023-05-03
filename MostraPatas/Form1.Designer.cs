namespace MostraPatas
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
            cboAnimais = new ComboBox();
            btnMostraPatas = new Button();
            pctAnimais = new PictureBox();
            label1 = new Label();
            btnAleatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)pctAnimais).BeginInit();
            SuspendLayout();
            // 
            // cboAnimais
            // 
            cboAnimais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAnimais.FormattingEnabled = true;
            cboAnimais.Location = new Point(23, 88);
            cboAnimais.Name = "cboAnimais";
            cboAnimais.Size = new Size(121, 23);
            cboAnimais.Sorted = true;
            cboAnimais.TabIndex = 0;
            cboAnimais.SelectedIndexChanged += cboAnimais_SelectedIndexChanged;
            // 
            // btnMostraPatas
            // 
            btnMostraPatas.Location = new Point(29, 130);
            btnMostraPatas.Name = "btnMostraPatas";
            btnMostraPatas.Size = new Size(109, 23);
            btnMostraPatas.TabIndex = 1;
            btnMostraPatas.Text = "Mostra Patas";
            btnMostraPatas.UseVisualStyleBackColor = true;
            btnMostraPatas.Click += btnMostraPatas_Click;
            // 
            // pctAnimais
            // 
            pctAnimais.Location = new Point(167, 46);
            pctAnimais.Name = "pctAnimais";
            pctAnimais.Size = new Size(176, 155);
            pctAnimais.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAnimais.TabIndex = 2;
            pctAnimais.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(338, 17);
            label1.TabIndex = 3;
            label1.Text = "Selecione o animal e descubra quantas patas ele tem!";
            // 
            // btnAleatorio
            // 
            btnAleatorio.Location = new Point(29, 159);
            btnAleatorio.Name = "btnAleatorio";
            btnAleatorio.Size = new Size(109, 23);
            btnAleatorio.TabIndex = 4;
            btnAleatorio.Text = "Animal Aleatório";
            btnAleatorio.UseVisualStyleBackColor = true;
            btnAleatorio.Click += btnAleatorio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 213);
            Controls.Add(btnAleatorio);
            Controls.Add(label1);
            Controls.Add(pctAnimais);
            Controls.Add(btnMostraPatas);
            Controls.Add(cboAnimais);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Animais";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctAnimais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboAnimais;
        private Button btnMostraPatas;
        private PictureBox pctAnimais;
        private Label label1;
        private Button btnAleatorio;
    }
}