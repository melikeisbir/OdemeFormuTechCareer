namespace OdemeFormuTechCareer
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
            lblMesaj = new Label();
            button1 = new Button();
            txtYazi = new TextBox();
            comboBox1 = new ComboBox();
            lblRenk = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(161, 73);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(54, 15);
            lblMesaj.TabIndex = 0;
            lblMesaj.Text = "Merhaba";
            // 
            // button1
            // 
            button1.Location = new Point(234, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Tıkla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtYazi
            // 
            txtYazi.BackColor = SystemColors.ActiveCaption;
            txtYazi.Location = new Point(243, 70);
            txtYazi.Name = "txtYazi";
            txtYazi.Size = new Size(100, 23);
            txtYazi.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Seçiniz", "Sarı", "Kırmızı", "Yeşil", "Mavi", "Beyaz" });
            comboBox1.Location = new Point(467, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(467, 130);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(38, 15);
            lblRenk.TabIndex = 4;
            lblRenk.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(467, 170);
            button2.Name = "button2";
            button2.Size = new Size(108, 23);
            button2.TabIndex = 5;
            button2.Text = "Renk Göster";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(lblRenk);
            Controls.Add(comboBox1);
            Controls.Add(txtYazi);
            Controls.Add(button1);
            Controls.Add(lblMesaj);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMesaj;
        private Button button1;
        private TextBox txtYazi;
        private ComboBox comboBox1;
        private Label lblRenk;
        private Button button2;
    }
}
