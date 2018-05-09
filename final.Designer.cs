namespace Game_menu
{
    partial class final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(final));
            this.panel1 = new System.Windows.Forms.Panel();
            this.screen = new System.Windows.Forms.Panel();
            this.zeus = new System.Windows.Forms.PictureBox();
            this.amove = new System.Windows.Forms.PictureBox();
            this.move = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amove)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-2, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 43);
            this.panel1.TabIndex = 0;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.screen.Controls.Add(this.zeus);
            this.screen.Controls.Add(this.amove);
            this.screen.Location = new System.Drawing.Point(-2, -2);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1094, 479);
            this.screen.TabIndex = 1;
            // 
            // zeus
            // 
            this.zeus.Image = ((System.Drawing.Image)(resources.GetObject("zeus.Image")));
            this.zeus.Location = new System.Drawing.Point(685, 269);
            this.zeus.Name = "zeus";
            this.zeus.Size = new System.Drawing.Size(238, 210);
            this.zeus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zeus.TabIndex = 2;
            this.zeus.TabStop = false;
            // 
            // amove
            // 
            this.amove.Image = ((System.Drawing.Image)(resources.GetObject("amove.Image")));
            this.amove.Location = new System.Drawing.Point(40, 417);
            this.amove.Name = "amove";
            this.amove.Size = new System.Drawing.Size(61, 59);
            this.amove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amove.TabIndex = 1;
            this.amove.TabStop = false;
            // 
            // move
            // 
            this.move.Tick += new System.EventHandler(this.move_Tick);
            // 
            // final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 514);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "final";
            this.Text = "final";
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zeus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox amove;
        private System.Windows.Forms.PictureBox zeus;
        private System.Windows.Forms.Timer move;

    }
}