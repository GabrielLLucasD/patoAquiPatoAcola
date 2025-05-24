namespace Patos2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnVerPatos = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVerPatos
            // 
            btnVerPatos.BackColor = Color.PaleGreen;
            btnVerPatos.Font = new Font("Segoe UI", 12F);
            btnVerPatos.Location = new Point(271, 361);
            btnVerPatos.Name = "btnVerPatos";
            btnVerPatos.Size = new Size(116, 45);
            btnVerPatos.TabIndex = 0;
            btnVerPatos.Text = "Ver Patos";
            btnVerPatos.UseVisualStyleBackColor = false;
            btnVerPatos.Click += btnVerPatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 27);
            label1.Name = "label1";
            label1.Size = new Size(562, 50);
            label1.TabIndex = 1;
            label1.Text = "Bem-vindo ao Mundo dos Patos!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.LightCoral;
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.Location = new Point(407, 361);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(116, 45);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnVerPatos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerPatos;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSair;
    }
}
