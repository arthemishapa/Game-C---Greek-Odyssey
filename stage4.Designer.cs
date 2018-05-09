namespace Game_menu
{
    partial class stage4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stage4));
            this.screen = new System.Windows.Forms.Panel();
            this.monster = new System.Windows.Forms.PictureBox();
            this.beam = new System.Windows.Forms.PictureBox();
            this.bug = new System.Windows.Forms.PictureBox();
            this.care = new System.Windows.Forms.PictureBox();
            this.auch = new System.Windows.Forms.PictureBox();
            this.proceed = new System.Windows.Forms.PictureBox();
            this.health = new System.Windows.Forms.PictureBox();
            this.road = new System.Windows.Forms.Panel();
            this.arrow5 = new System.Windows.Forms.PictureBox();
            this.arrow4 = new System.Windows.Forms.PictureBox();
            this.arrow3 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.amove = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.move = new System.Windows.Forms.Timer(this.components);
            this.arrowt = new System.Windows.Forms.Timer(this.components);
            this.bomb = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.care)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amove)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.screen.Controls.Add(this.monster);
            this.screen.Controls.Add(this.beam);
            this.screen.Controls.Add(this.bug);
            this.screen.Controls.Add(this.care);
            this.screen.Controls.Add(this.auch);
            this.screen.Controls.Add(this.proceed);
            this.screen.Controls.Add(this.health);
            this.screen.Controls.Add(this.road);
            this.screen.Controls.Add(this.arrow5);
            this.screen.Controls.Add(this.arrow4);
            this.screen.Controls.Add(this.arrow3);
            this.screen.Controls.Add(this.arrow2);
            this.screen.Controls.Add(this.arrow1);
            this.screen.Controls.Add(this.amove);
            this.screen.Location = new System.Drawing.Point(0, 1);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1171, 492);
            this.screen.TabIndex = 4;
            // 
            // monster
            // 
            this.monster.Image = ((System.Drawing.Image)(resources.GetObject("monster.Image")));
            this.monster.Location = new System.Drawing.Point(1096, 433);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(63, 59);
            this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monster.TabIndex = 31;
            this.monster.TabStop = false;
            // 
            // beam
            // 
            this.beam.Image = ((System.Drawing.Image)(resources.GetObject("beam.Image")));
            this.beam.Location = new System.Drawing.Point(707, 310);
            this.beam.Name = "beam";
            this.beam.Size = new System.Drawing.Size(18, 59);
            this.beam.TabIndex = 30;
            this.beam.TabStop = false;
            this.beam.Visible = false;
            // 
            // bug
            // 
            this.bug.Image = ((System.Drawing.Image)(resources.GetObject("bug.Image")));
            this.bug.Location = new System.Drawing.Point(731, 310);
            this.bug.Name = "bug";
            this.bug.Size = new System.Drawing.Size(63, 59);
            this.bug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bug.TabIndex = 29;
            this.bug.TabStop = false;
            // 
            // care
            // 
            this.care.BackColor = System.Drawing.Color.Transparent;
            this.care.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("care.BackgroundImage")));
            this.care.Image = ((System.Drawing.Image)(resources.GetObject("care.Image")));
            this.care.Location = new System.Drawing.Point(12, 67);
            this.care.Name = "care";
            this.care.Size = new System.Drawing.Size(161, 32);
            this.care.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.care.TabIndex = 18;
            this.care.TabStop = false;
            this.care.Visible = false;
            // 
            // auch
            // 
            this.auch.Image = ((System.Drawing.Image)(resources.GetObject("auch.Image")));
            this.auch.Location = new System.Drawing.Point(64, 326);
            this.auch.Name = "auch";
            this.auch.Size = new System.Drawing.Size(61, 50);
            this.auch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auch.TabIndex = 17;
            this.auch.TabStop = false;
            this.auch.Visible = false;
            // 
            // proceed
            // 
            this.proceed.Image = ((System.Drawing.Image)(resources.GetObject("proceed.Image")));
            this.proceed.Location = new System.Drawing.Point(864, 331);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(295, 38);
            this.proceed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.proceed.TabIndex = 14;
            this.proceed.TabStop = false;
            this.proceed.Visible = false;
            // 
            // health
            // 
            this.health.Image = ((System.Drawing.Image)(resources.GetObject("health.Image")));
            this.health.Location = new System.Drawing.Point(3, 3);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(113, 50);
            this.health.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health.TabIndex = 11;
            this.health.TabStop = false;
            // 
            // road
            // 
            this.road.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("road.BackgroundImage")));
            this.road.Location = new System.Drawing.Point(350, 370);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(444, 41);
            this.road.TabIndex = 8;
            // 
            // arrow5
            // 
            this.arrow5.Location = new System.Drawing.Point(238, 104);
            this.arrow5.Name = "arrow5";
            this.arrow5.Size = new System.Drawing.Size(53, 15);
            this.arrow5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow5.TabIndex = 5;
            this.arrow5.TabStop = false;
            // 
            // arrow4
            // 
            this.arrow4.Location = new System.Drawing.Point(12, 11);
            this.arrow4.Name = "arrow4";
            this.arrow4.Size = new System.Drawing.Size(53, 15);
            this.arrow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow4.TabIndex = 4;
            this.arrow4.TabStop = false;
            // 
            // arrow3
            // 
            this.arrow3.Location = new System.Drawing.Point(12, 11);
            this.arrow3.Name = "arrow3";
            this.arrow3.Size = new System.Drawing.Size(53, 15);
            this.arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow3.TabIndex = 3;
            this.arrow3.TabStop = false;
            // 
            // arrow2
            // 
            this.arrow2.Location = new System.Drawing.Point(3, 11);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(53, 15);
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow2.TabIndex = 2;
            this.arrow2.TabStop = false;
            // 
            // arrow1
            // 
            this.arrow1.Location = new System.Drawing.Point(3, 11);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(53, 15);
            this.arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow1.TabIndex = 1;
            this.arrow1.TabStop = false;
            // 
            // amove
            // 
            this.amove.Image = ((System.Drawing.Image)(resources.GetObject("amove.Image")));
            this.amove.Location = new System.Drawing.Point(64, 382);
            this.amove.Name = "amove";
            this.amove.Size = new System.Drawing.Size(61, 59);
            this.amove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amove.TabIndex = 0;
            this.amove.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 47);
            this.panel2.TabIndex = 19;
            // 
            // move
            // 
            this.move.Tick += new System.EventHandler(this.move_Tick);
            // 
            // arrowt
            // 
            this.arrowt.Tick += new System.EventHandler(this.arrowt_Tick);
            // 
            // bomb
            // 
            this.bomb.Tick += new System.EventHandler(this.bomb_Tick);
            // 
            // stage4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stage4";
            this.Text = "stage4";
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.care)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox care;
        private System.Windows.Forms.PictureBox auch;
        private System.Windows.Forms.PictureBox proceed;
        private System.Windows.Forms.PictureBox health;
        private System.Windows.Forms.Panel road;
        private System.Windows.Forms.PictureBox arrow5;
        private System.Windows.Forms.PictureBox arrow4;
        private System.Windows.Forms.PictureBox arrow3;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox amove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox bug;
        private System.Windows.Forms.PictureBox beam;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.Timer move;
        private System.Windows.Forms.Timer arrowt;
        private System.Windows.Forms.Timer bomb;

    }
}