namespace Proje_BilgiYarışması
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btna = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblyanlıs = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(611, 196);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btna
            // 
            this.btna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btna.Location = new System.Drawing.Point(12, 228);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(294, 84);
            this.btna.TabIndex = 1;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // btnb
            // 
            this.btnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnb.Location = new System.Drawing.Point(329, 228);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(294, 84);
            this.btnb.TabIndex = 2;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnc
            // 
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnc.Location = new System.Drawing.Point(12, 334);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(294, 84);
            this.btnc.TabIndex = 3;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnd
            // 
            this.btnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnd.Location = new System.Drawing.Point(329, 334);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(294, 84);
            this.btnd.TabIndex = 4;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.btnd_Click);
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoruno.ForeColor = System.Drawing.Color.White;
            this.lblsoruno.Location = new System.Drawing.Point(666, 33);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(108, 29);
            this.lblsoruno.TabIndex = 5;
            this.lblsoruno.Text = "Soru No:";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogru.ForeColor = System.Drawing.Color.White;
            this.lbldogru.Location = new System.Drawing.Point(666, 76);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(85, 29);
            this.lbldogru.TabIndex = 6;
            this.lbldogru.Text = "Doğru:";
            // 
            // lblyanlıs
            // 
            this.lblyanlıs.AutoSize = true;
            this.lblyanlıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyanlıs.ForeColor = System.Drawing.Color.White;
            this.lblyanlıs.Location = new System.Drawing.Point(666, 123);
            this.lblyanlıs.Name = "lblyanlıs";
            this.lblyanlıs.Size = new System.Drawing.Size(85, 29);
            this.lblyanlıs.TabIndex = 7;
            this.lblyanlıs.Text = "Yanlış:";
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoru.ForeColor = System.Drawing.Color.White;
            this.lblsoru.Location = new System.Drawing.Point(794, 33);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(26, 29);
            this.lblsoru.TabIndex = 8;
            this.lblsoru.Text = "0";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbld.ForeColor = System.Drawing.Color.White;
            this.lbld.Location = new System.Drawing.Point(794, 76);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(26, 29);
            this.lbld.TabIndex = 9;
            this.lbld.Text = "0";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbly.ForeColor = System.Drawing.Color.White;
            this.lbly.Location = new System.Drawing.Point(794, 123);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(26, 29);
            this.lbly.TabIndex = 10;
            this.lbly.Text = "0";
            // 
            // btnsonraki
            // 
            this.btnsonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsonraki.Location = new System.Drawing.Point(654, 157);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(232, 51);
            this.btnsonraki.TabIndex = 11;
            this.btnsonraki.Text = "Sonraki Soru";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(677, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(677, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(948, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.lblyanlıs);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label lblyanlıs;
        private System.Windows.Forms.Label lblsoru;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

