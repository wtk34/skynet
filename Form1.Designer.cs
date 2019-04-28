namespace SkyNet
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtSayBox = new System.Windows.Forms.TextBox();
            this.txtCmdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxtSayBox
            // 
            this.TxtSayBox.Enabled = false;
            this.TxtSayBox.ForeColor = System.Drawing.Color.Red;
            this.TxtSayBox.Location = new System.Drawing.Point(12, 231);
            this.TxtSayBox.Multiline = true;
            this.TxtSayBox.Name = "TxtSayBox";
            this.TxtSayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSayBox.Size = new System.Drawing.Size(182, 126);
            this.TxtSayBox.TabIndex = 1;
            // 
            // txtCmdBox
            // 
            this.txtCmdBox.Enabled = false;
            this.txtCmdBox.Location = new System.Drawing.Point(286, 231);
            this.txtCmdBox.Multiline = true;
            this.txtCmdBox.Name = "txtCmdBox";
            this.txtCmdBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCmdBox.Size = new System.Drawing.Size(182, 126);
            this.txtCmdBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "State";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(480, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCmdBox);
            this.Controls.Add(this.TxtSayBox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SkyNet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtSayBox;
        private System.Windows.Forms.TextBox txtCmdBox;
        private System.Windows.Forms.Label label1;
    }
}

