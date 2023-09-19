namespace adam_asmaca
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcB5 = new System.Windows.Forms.PictureBox();
            this.pcB4 = new System.Windows.Forms.PictureBox();
            this.pcB3 = new System.Windows.Forms.PictureBox();
            this.pcB2 = new System.Windows.Forms.PictureBox();
            this.pcB1 = new System.Windows.Forms.PictureBox();
            this.pcB6 = new System.Windows.Forms.PictureBox();
            this.lblKelime = new System.Windows.Forms.Label();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB6)).BeginInit();
            this.SuspendLayout();
            // 
            // pcB5
            // 
            this.pcB5.Image = ((System.Drawing.Image)(resources.GetObject("pcB5.Image")));
            this.pcB5.Location = new System.Drawing.Point(20, 258);
            this.pcB5.Name = "pcB5";
            this.pcB5.Size = new System.Drawing.Size(141, 91);
            this.pcB5.TabIndex = 68;
            this.pcB5.TabStop = false;
            this.pcB5.Visible = false;
            // 
            // pcB4
            // 
            this.pcB4.Image = ((System.Drawing.Image)(resources.GetObject("pcB4.Image")));
            this.pcB4.Location = new System.Drawing.Point(89, 159);
            this.pcB4.Name = "pcB4";
            this.pcB4.Size = new System.Drawing.Size(10, 108);
            this.pcB4.TabIndex = 65;
            this.pcB4.TabStop = false;
            this.pcB4.Visible = false;
            // 
            // pcB3
            // 
            this.pcB3.Image = ((System.Drawing.Image)(resources.GetObject("pcB3.Image")));
            this.pcB3.Location = new System.Drawing.Point(53, 80);
            this.pcB3.Name = "pcB3";
            this.pcB3.Size = new System.Drawing.Size(83, 86);
            this.pcB3.TabIndex = 64;
            this.pcB3.TabStop = false;
            this.pcB3.Visible = false;
            // 
            // pcB2
            // 
            this.pcB2.Image = ((System.Drawing.Image)(resources.GetObject("pcB2.Image")));
            this.pcB2.Location = new System.Drawing.Point(89, 36);
            this.pcB2.Name = "pcB2";
            this.pcB2.Size = new System.Drawing.Size(8, 47);
            this.pcB2.TabIndex = 63;
            this.pcB2.TabStop = false;
            this.pcB2.Visible = false;
            // 
            // pcB1
            // 
            this.pcB1.Image = ((System.Drawing.Image)(resources.GetObject("pcB1.Image")));
            this.pcB1.Location = new System.Drawing.Point(89, 36);
            this.pcB1.Name = "pcB1";
            this.pcB1.Size = new System.Drawing.Size(150, 10);
            this.pcB1.TabIndex = 62;
            this.pcB1.TabStop = false;
            this.pcB1.Visible = false;
            // 
            // pcB6
            // 
            this.pcB6.Image = ((System.Drawing.Image)(resources.GetObject("pcB6.Image")));
            this.pcB6.Location = new System.Drawing.Point(20, 201);
            this.pcB6.Name = "pcB6";
            this.pcB6.Size = new System.Drawing.Size(150, 10);
            this.pcB6.TabIndex = 69;
            this.pcB6.TabStop = false;
            this.pcB6.Visible = false;
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(338, 243);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(66, 24);
            this.lblKelime.TabIndex = 70;
            this.lblKelime.Text = "label1";
            // 
            // txtHarf
            // 
            this.txtHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf.Location = new System.Drawing.Point(331, 80);
            this.txtHarf.MaxLength = 1;
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(35, 29);
            this.txtHarf.TabIndex = 71;
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(372, 80);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(59, 29);
            this.btnTahmin.TabIndex = 72;
            this.btnTahmin.Text = "Tahmin";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 417);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtHarf);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.pcB3);
            this.Controls.Add(this.pcB4);
            this.Controls.Add(this.pcB6);
            this.Controls.Add(this.pcB5);
            this.Controls.Add(this.pcB2);
            this.Controls.Add(this.pcB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcB5;
        private System.Windows.Forms.PictureBox pcB4;
        private System.Windows.Forms.PictureBox pcB3;
        private System.Windows.Forms.PictureBox pcB2;
        private System.Windows.Forms.PictureBox pcB1;
        private System.Windows.Forms.PictureBox pcB6;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button btnTahmin;
    }
}

