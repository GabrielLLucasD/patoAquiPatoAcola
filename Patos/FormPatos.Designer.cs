namespace Patos2
{
    partial class FormPatos
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
            pictureBoxPato = new PictureBox();
            btnAnterior = new Button();
            btnProximo = new Button();
            btnEscolher = new Button();
            lblNome = new Label();
            panelPoderes = new Panel();
            lblPoderes = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPato).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPato
            // 
            pictureBoxPato.Location = new Point(212, 85);
            pictureBoxPato.Name = "pictureBoxPato";
            pictureBoxPato.Size = new Size(367, 236);
            pictureBoxPato.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPato.TabIndex = 0;
            pictureBoxPato.TabStop = false;
            pictureBoxPato.Click += pictureBoxPato_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(38, 168);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(60, 75);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProximo.Location = new Point(688, 168);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(60, 75);
            btnProximo.TabIndex = 3;
            btnProximo.Text = ">";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnEscolher
            // 
            btnEscolher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEscolher.Location = new Point(338, 385);
            btnEscolher.Name = "btnEscolher";
            btnEscolher.Size = new Size(105, 38);
            btnEscolher.TabIndex = 4;
            btnEscolher.Text = "Escolher";
            btnEscolher.UseVisualStyleBackColor = true;
            btnEscolher.Click += btnEscolher_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(316, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(150, 37);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome Pato";
            // 
            // panelPoderes
            // 
            panelPoderes.Location = new Point(38, 429);
            panelPoderes.Name = "panelPoderes";
            panelPoderes.Size = new Size(710, 100);
            panelPoderes.TabIndex = 6;
            // 
            // lblPoderes
            // 
            lblPoderes.AutoSize = true;
            lblPoderes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoderes.Location = new Point(228, 336);
            lblPoderes.Name = "lblPoderes";
            lblPoderes.Size = new Size(0, 21);
            lblPoderes.TabIndex = 7;
            // 
            // FormPatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(lblPoderes);
            Controls.Add(panelPoderes);
            Controls.Add(lblNome);
            Controls.Add(btnEscolher);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(pictureBoxPato);
            Name = "FormPatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPatos";
            Load += FormPatos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPato;
        private Button btnAnterior;
        private Button btnProximo;
        private Button btnEscolher;
        private Label lblNome;
        private Panel panelPoderes;
        private Label lblPoderes;
    }
}