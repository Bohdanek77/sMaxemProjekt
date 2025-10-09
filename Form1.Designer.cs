namespace sMaxemProjekt
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
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            vysledek = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(844, 178);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 1;
            label2.Text = "=";
            label2.Click += label2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(603, 266);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Vypočítat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(644, 183);
            label1.MaximumSize = new Size(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 3;
            label1.Text = "0";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Snímek_obrazovky_2025_04_28_082933;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-5, 673);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 49);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // vysledek
            // 
            vysledek.AutoSize = true;
            vysledek.Location = new Point(898, 183);
            vysledek.Name = "vysledek";
            vysledek.Size = new Size(22, 25);
            vysledek.TabIndex = 5;
            vysledek.Text = "0";
            vysledek.Click += vysledek_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1457, 721);
            Controls.Add(vysledek);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label vysledek;
    }
}
