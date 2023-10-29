namespace for4_1575
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
            txtBaslangic = new TextBox();
            txtBitis = new TextBox();
            lbSayilar = new ListBox();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // txtBaslangic
            // 
            txtBaslangic.Location = new Point(24, 22);
            txtBaslangic.Name = "txtBaslangic";
            txtBaslangic.Size = new Size(125, 27);
            txtBaslangic.TabIndex = 0;
            // 
            // txtBitis
            // 
            txtBitis.Location = new Point(167, 22);
            txtBitis.Name = "txtBitis";
            txtBitis.Size = new Size(125, 27);
            txtBitis.TabIndex = 1;
            // 
            // lbSayilar
            // 
            lbSayilar.FormattingEnabled = true;
            lbSayilar.ItemHeight = 20;
            lbSayilar.Location = new Point(24, 70);
            lbSayilar.Name = "lbSayilar";
            lbSayilar.Size = new Size(125, 324);
            lbSayilar.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.SpringGreen;
            btnEkle.Location = new Point(168, 94);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 47);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(318, 411);
            Controls.Add(btnEkle);
            Controls.Add(lbSayilar);
            Controls.Add(txtBitis);
            Controls.Add(txtBaslangic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBaslangic;
        private TextBox txtBitis;
        private ListBox lbSayilar;
        private Button btnEkle;
    }
}