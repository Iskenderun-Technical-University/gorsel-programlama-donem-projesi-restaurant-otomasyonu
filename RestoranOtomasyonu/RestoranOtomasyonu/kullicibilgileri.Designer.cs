namespace RestoranOtomasyonu
{
    partial class kullicibilgileri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.SoyadLabel = new System.Windows.Forms.Label();
            this.AdıLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.telefonTextBox);
            this.panel1.Controls.Add(this.AdresTextBox);
            this.panel1.Controls.Add(this.SoyadTextBox);
            this.panel1.Controls.Add(this.isimTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AdresLabel);
            this.panel1.Controls.Add(this.SoyadLabel);
            this.panel1.Controls.Add(this.AdıLabel);
            this.panel1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(21, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 574);
            this.panel1.TabIndex = 0;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(183, 197);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(239, 32);
            this.telefonTextBox.TabIndex = 7;
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.Location = new System.Drawing.Point(183, 139);
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(239, 32);
            this.AdresTextBox.TabIndex = 6;
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Location = new System.Drawing.Point(183, 81);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(239, 32);
            this.SoyadTextBox.TabIndex = 5;
            // 
            // isimTextBox
            // 
            this.isimTextBox.Location = new System.Drawing.Point(183, 26);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(239, 32);
            this.isimTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHONE NUMBER:";
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Location = new System.Drawing.Point(20, 142);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(89, 20);
            this.AdresLabel.TabIndex = 2;
            this.AdresLabel.Text = "ADDRESS:";
            // 
            // SoyadLabel
            // 
            this.SoyadLabel.AutoSize = true;
            this.SoyadLabel.Location = new System.Drawing.Point(20, 84);
            this.SoyadLabel.Name = "SoyadLabel";
            this.SoyadLabel.Size = new System.Drawing.Size(97, 20);
            this.SoyadLabel.TabIndex = 1;
            this.SoyadLabel.Text = "SURNAME:";
            // 
            // AdıLabel
            // 
            this.AdıLabel.AutoSize = true;
            this.AdıLabel.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AdıLabel.Location = new System.Drawing.Point(20, 27);
            this.AdıLabel.Name = "AdıLabel";
            this.AdıLabel.Size = new System.Drawing.Size(72, 22);
            this.AdıLabel.TabIndex = 0;
            this.AdıLabel.Text = "NAME:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullicibilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1051, 619);
            this.Controls.Add(this.panel1);
            this.Name = "kullicibilgileri";
            this.Text = "kullicibilgileri";
            this.Load += new System.EventHandler(this.kullicibilgileri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label AdıLabel;
        private Label SoyadLabel;
        private TextBox telefonTextBox;
        private TextBox AdresTextBox;
        private TextBox SoyadTextBox;
        private TextBox isimTextBox;
        private Label label1;
        private Label AdresLabel;
        private Button button1;
    }
}