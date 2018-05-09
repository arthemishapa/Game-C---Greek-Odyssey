namespace Game_menu
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
            this.Artemis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RichTextBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Artemis
            // 
            this.Artemis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Artemis.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Artemis.FlatAppearance.BorderSize = 50;
            this.Artemis.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artemis.ForeColor = System.Drawing.Color.LightBlue;
            this.Artemis.Location = new System.Drawing.Point(133, 361);
            this.Artemis.Name = "Artemis";
            this.Artemis.Size = new System.Drawing.Size(167, 53);
            this.Artemis.TabIndex = 11;
            this.Artemis.Text = "Play game";
            this.Artemis.UseVisualStyleBackColor = false;
            this.Artemis.Click += new System.EventHandler(this.Artemis_Click);
            this.Artemis.MouseLeave += new System.EventHandler(this.Artemis_MouseLeave);
            this.Artemis.MouseHover += new System.EventHandler(this.Artemis_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 50;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightBlue;
            this.button2.Location = new System.Drawing.Point(325, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "Greek Odyssey";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.Window;
            this.info.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(586, 322);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(300, 234);
            this.info.TabIndex = 14;
            this.info.Text = "";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderSize = 50;
            this.exit.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.LightBlue;
            this.exit.Location = new System.Drawing.Point(133, 455);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(167, 53);
            this.exit.TabIndex = 15;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1033, 624);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Artemis);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Atestat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Artemis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Button exit;
    }
}

