namespace DijitalSaati
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsaat = new System.Windows.Forms.Label();
            this.lbldak = new System.Windows.Forms.Label();
            this.lblsan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.ForeColor = System.Drawing.Color.White;
            this.lblsaat.Location = new System.Drawing.Point(51, 137);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(24, 25);
            this.lblsaat.TabIndex = 0;
            this.lblsaat.Text = "0";
            // 
            // lbldak
            // 
            this.lbldak.AutoSize = true;
            this.lbldak.ForeColor = System.Drawing.Color.White;
            this.lbldak.Location = new System.Drawing.Point(121, 137);
            this.lbldak.Name = "lbldak";
            this.lbldak.Size = new System.Drawing.Size(24, 25);
            this.lbldak.TabIndex = 1;
            this.lbldak.Text = "0";
            // 
            // lblsan
            // 
            this.lblsan.AutoSize = true;
            this.lblsan.ForeColor = System.Drawing.Color.White;
            this.lblsan.Location = new System.Drawing.Point(178, 137);
            this.lblsan.Name = "lblsan";
            this.lblsan.Size = new System.Drawing.Size(24, 25);
            this.lblsan.TabIndex = 2;
            this.lblsan.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(310, 419);
            this.Controls.Add(this.lblsan);
            this.Controls.Add(this.lbldak);
            this.Controls.Add(this.lblsaat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Label lbldak;
        private System.Windows.Forms.Label lblsan;
    }
}

