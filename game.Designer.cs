namespace Game_menu
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.move = new System.Windows.Forms.Timer(this.components);
            this.arrowt = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.proceed = new System.Windows.Forms.PictureBox();
            this.arrow3 = new System.Windows.Forms.PictureBox();
            this.arrow4 = new System.Windows.Forms.PictureBox();
            this.arrow5 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.tuto = new System.Windows.Forms.PictureBox();
            this.tutorial = new System.Windows.Forms.PictureBox();
            this.amove = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proceed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amove)).BeginInit();
            this.SuspendLayout();
            // 
            // move
            // 
            this.move.Tick += new System.EventHandler(this.move_Tick);
            // 
            // arrowt
            // 
            this.arrowt.Tick += new System.EventHandler(this.arrowt_Tick);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.White;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screen.Controls.Add(this.proceed);
            this.screen.Controls.Add(this.arrow3);
            this.screen.Controls.Add(this.arrow4);
            this.screen.Controls.Add(this.arrow5);
            this.screen.Controls.Add(this.arrow2);
            this.screen.Controls.Add(this.arrow1);
            this.screen.Controls.Add(this.tuto);
            this.screen.Controls.Add(this.tutorial);
            this.screen.Controls.Add(this.amove);
            this.screen.Dock = System.Windows.Forms.DockStyle.Top;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1146, 488);
            this.screen.TabIndex = 0;
            // 
            // proceed
            // 
            this.proceed.Image = ((System.Drawing.Image)(resources.GetObject("proceed.Image")));
            this.proceed.Location = new System.Drawing.Point(747, 349);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(397, 36);
            this.proceed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.proceed.TabIndex = 13;
            this.proceed.TabStop = false;
            this.proceed.Visible = false;
            // 
            // arrow3
            // 
            this.arrow3.Location = new System.Drawing.Point(508, 296);
            this.arrow3.Name = "arrow3";
            this.arrow3.Size = new System.Drawing.Size(53, 15);
            this.arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow3.TabIndex = 12;
            this.arrow3.TabStop = false;
            this.arrow3.Visible = false;
            // 
            // arrow4
            // 
            this.arrow4.Location = new System.Drawing.Point(362, 217);
            this.arrow4.Name = "arrow4";
            this.arrow4.Size = new System.Drawing.Size(53, 15);
            this.arrow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow4.TabIndex = 11;
            this.arrow4.TabStop = false;
            this.arrow4.Visible = false;
            // 
            // arrow5
            // 
            this.arrow5.Location = new System.Drawing.Point(521, 217);
            this.arrow5.Name = "arrow5";
            this.arrow5.Size = new System.Drawing.Size(53, 15);
            this.arrow5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow5.TabIndex = 10;
            this.arrow5.TabStop = false;
            this.arrow5.Visible = false;
            // 
            // arrow2
            // 
            this.arrow2.Location = new System.Drawing.Point(349, 296);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(53, 15);
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow2.TabIndex = 9;
            this.arrow2.TabStop = false;
            this.arrow2.Visible = false;
            // 
            // arrow1
            // 
            this.arrow1.Location = new System.Drawing.Point(614, 288);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(53, 15);
            this.arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow1.TabIndex = 8;
            this.arrow1.TabStop = false;
            this.arrow1.Visible = false;
            // 
            // tuto
            // 
            this.tuto.BackColor = System.Drawing.Color.Transparent;
            this.tuto.Image = ((System.Drawing.Image)(resources.GetObject("tuto.Image")));
            this.tuto.Location = new System.Drawing.Point(52, 26);
            this.tuto.Name = "tuto";
            this.tuto.Size = new System.Drawing.Size(1055, 112);
            this.tuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tuto.TabIndex = 7;
            this.tuto.TabStop = false;
            // 
            // tutorial
            // 
            this.tutorial.Image = ((System.Drawing.Image)(resources.GetObject("tutorial.Image")));
            this.tutorial.Location = new System.Drawing.Point(-153, 66);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(100, 50);
            this.tutorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tutorial.TabIndex = 6;
            this.tutorial.TabStop = false;
            // 
            // amove
            // 
            this.amove.BackColor = System.Drawing.SystemColors.HighlightText;
            this.amove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.amove.Image = ((System.Drawing.Image)(resources.GetObject("amove.Image")));
            this.amove.Location = new System.Drawing.Point(183, 339);
            this.amove.Name = "amove";
            this.amove.Size = new System.Drawing.Size(61, 59);
            this.amove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amove.TabIndex = 0;
            this.amove.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 35);
            this.panel1.TabIndex = 1;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1146, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proceed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer move;
        private System.Windows.Forms.Timer arrowt;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox amove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox tutorial;
        private System.Windows.Forms.PictureBox tuto;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox arrow3;
        private System.Windows.Forms.PictureBox arrow4;
        private System.Windows.Forms.PictureBox arrow5;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.PictureBox proceed;
    }
}