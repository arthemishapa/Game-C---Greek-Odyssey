using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_menu
{
    public partial class stage5 : Form
    {
         //vector pentru sageti
        PictureBox[] arrow = new PictureBox[6];

        //vector care tine evidenta sagetilor si directia in care se indreapta
        int[] fata = new int[6];
        int l = scor.h;
        public stage5()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);

            
            health.Image = Image.FromFile(l + "_heart.jpg");
            //locatii picturebox
            amove.Top = screen.Height - amove.Height;
            bug.Top = road.Location.Y - bug.Height;
            monster.Top = screen.Height - monster.Height;

            //timer pentru bombele cazatoare
            Timer bomb = new Timer();
            bomb.Tick += new EventHandler(bomb_Tick);
            bomb.Interval = 1000;
            bomb.Enabled = false;

            //timer pentru animatie
            Timer move = new Timer();
            move.Tick += new EventHandler(move_Tick);
            move.Interval = 1000;
            move.Enabled = false;


            //timer pentru sageti
            Timer arrowt = new Timer();
            arrowt.Tick += new EventHandler(arrowt_Tick);
            arrowt.Interval = 1;
            arrowt.Enabled = false;
            arrow[1] = arrow1;
            arrow[2] = arrow2;
            arrow[3] = arrow3;
            arrow[4] = arrow4;
            arrow[5] = arrow5;
        }
        int k = 1, sus, i = 0, en = 3;       // k = index pentru pozele de miscare; i = contor pentru sageti; sus = cat sare; h health bar index; en = nr. inamicilor
        bool jump = false;                          // verifica daca personajul sare sau nu
        bool right = true;                          // verifica in ce directie merge personajul
        bool down = false, b = true, gaza = true;   // verifica daca au ajuns jos bombele; b = sensul bombelor; gaza = sensul gazei

        // haosul prin care personajul se misca cum trebuie
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (jump == false)
                if (right == true)
                    amove.Image = Image.FromFile("amove_" + k + ".jpg");
                else amove.Image = Image.FromFile("amove_" + k + "_left.jpg");
            switch (e.KeyCode)
            {
                case Keys.Left:
                    right = false;
                    move.Enabled = true;
                    amove.Left -= 10;
                    break;
                case Keys.Right:
                    bomb.Enabled = true;
                    right = true;
                    move.Enabled = true;
                    amove.Left += 10;
                    break;
                case Keys.Space:
                    i++;
                    if (i == 6) i = 1;
                    arrow[i].Location = amove.Location;
                    arrow[i].Visible = true;
                    if (right == true)
                    {
                        if (jump == false) amove.Image = Image.FromFile("shoot.jpg");
                        arrow[i].Image = Image.FromFile("arrow.jpg");
                        fata[i] = 1;
                    }
                    else
                    {
                        if (jump == false) amove.Image = Image.FromFile("shoot_left.jpg");
                        arrow[i].Image = Image.FromFile("arrow_left.jpg");
                        fata[i] = -1;
                    }
                    arrowt.Enabled = true;
                    break;
                case Keys.Up:
                    if (jump == false)
                    {
                        sus = 40;
                        jump = true;
                    }
                    move.Enabled = true;
                    break;
                case Keys.Escape:
                    scor.esc = true;
                    this.Close();
                    break;
            }
        }

        private void move_Tick(object sender, EventArgs e)
        {
            //daca sare cade treptat
            if (jump == true)
            {
                amove.Top -= sus;
                sus -= 5;

                //isi schimba sensul cand sare in functie de stanga sau dreapta
                if (right == true)
                    amove.Image = Image.FromFile("jump.jpg");
                else amove.Image = Image.FromFile("jump_left.jpg");
            }

            //pica de pe platforma
            if (!(amove.Left + amove.Width > road.Left && amove.Left + amove.Width < road.Left + road.Width + amove.Width) && amove.Top + amove.Height >= road.Top && amove.Top < road.Top)
            {
                jump = true;
            }
            if (amove.Left + amove.Width + 20 > road2.Left + road2.Width + amove.Width && amove.Top + amove.Height >= road2.Top && amove.Top < road2.Top)
            {
                jump = true;
            }

            //sare pe platforma / pica pe platforma
            if (amove.Left + amove.Width > road.Left && amove.Left + amove.Width < road.Left + road.Width + amove.Width && amove.Top + amove.Height >= road.Top && amove.Top < road.Top)
            {
                amove.Top = road.Location.Y - amove.Height; jump = false;
            }
            if (amove.Top + amove.Height >= screen.Height)
            {
                amove.Top = screen.Height - amove.Height; jump = false;
            }
            if (amove.Left + amove.Width > road2.Left && amove.Left + amove.Width < road2.Left + road2.Width + amove.Width && amove.Top + amove.Height >= road2.Top && amove.Top < road2.Top)
            {
                amove.Top = road2.Location.Y - amove.Height; jump = false;
            }
            if (amove.Left + amove.Width > road3.Left && amove.Left + amove.Width < road3.Left + road3.Width + amove.Width && amove.Top + amove.Height >= road3.Top && amove.Top < road3.Top)
            {
                amove.Top = road3.Location.Y - amove.Height; jump = false;
            }



            //daca are obstacol in sus
            if (amove.Left + amove.Width > road.Left && amove.Left + amove.Width < road.Left + road.Width + amove.Width && amove.Top - road.Bottom <= 1 && amove.Top - road.Top > -1)
            {
                amove.Top = screen.Height - amove.Height; jump = false;
            }
            



            //daca nu sare executa miscarea normala in functie de stanga/dreapta
            if (jump == false)
            {
                if (right == true)
                {
                    amove.Image = Image.FromFile("amove_" + k + ".jpg");
                    k++;
                    if (k > 4) k = 1;
                    amove.Image = Image.FromFile("astop.jpg");
                    move.Enabled = false;
                }
                else
                {
                    amove.Image = Image.FromFile("amove_" + k + "_left.jpg");
                    k++;
                    if (k > 4) k = 1;
                    amove.Image = Image.FromFile("astop_left.jpg");
                    move.Enabled = false;
                }
            }

            //daca se loveste de inamic
            if (amove.Left + amove.Width > bomb1.Left && amove.Left + amove.Width < bomb1.Left + bomb1.Width + amove.Width && amove.Bottom <= bomb1.Bottom && amove.Top >= bomb1.Top && bomb1.Visible == true)
            {
                if (l == 1) care.Visible = true;
                if (l > 0)
                {
                    l--; scor.h--;
                    health.Image = Image.FromFile(l + "_heart.jpg"); 
                    auch.Location = amove.Location;
                    auch.Visible = true;
                }
                if (l == 0)
                {
                    
                    this.DialogResult = DialogResult.Cancel;
                } 
            }
            if (amove.Left + amove.Width > bomb2.Left && amove.Left + amove.Width < bomb2.Left + bomb2.Width + amove.Width && amove.Bottom <= bomb2.Bottom && amove.Top >= bomb2.Top && bomb2.Visible == true)
            {
                if (l == 1) care.Visible = true;
                if (l > 0)
                {
                    l--; scor.h--;
                    health.Image = Image.FromFile(l + "_heart.jpg"); 
                    auch.Location = amove.Location;
                    auch.Visible = true;
                }
                if (l == 0)
                {
                    
                    this.DialogResult = DialogResult.Cancel;
                }
                
            }
            if (amove.Left + amove.Width > bug.Left && amove.Left + amove.Width < bug.Left + bug.Width + amove.Width && amove.Bottom <= bug.Bottom && amove.Top >= bug.Top && bug.Visible == true)
            {
                if (l == 1) care.Visible = true;
                if (l > 0)
                {
                    l--; scor.h--;
                    health.Image = Image.FromFile(l + "_heart.jpg");
                    auch.Location = amove.Location;
                    auch.Visible = true;
                }
                if (l == 0)
                {

                    this.DialogResult = DialogResult.Cancel;
                }
            }


            //daca a terminat
            if (amove.Right > screen.Right && proceed.Visible == true)
            { this.DialogResult = DialogResult.Cancel; }
        }

        private void arrowt_Tick(object sender, EventArgs e)
        {
            for (int l = 1; l <= 5; l++)
            {
                if (fata[l] == 1)
                {
                    arrow[l].Left += 60;

                }
                else if (fata[l] == -1)
                {
                    arrow[l].Left -= 60;

                }
                if (arrow[l].Right >= screen.Right)
                {
                    fata[l] = 0;
                    arrow[l].Visible = false;
                    arrow[l].Location = amove.Location;
                }
                if (arrow[l].Left <= screen.Left)
                {
                    fata[l] = 0;
                    arrow[l].Visible = false;
                    arrow[l].Location = amove.Location;
                }

                //daca loveste inamic
                if (arrow[l].Left + arrow[l].Width > bomb1.Left && arrow[l].Left + arrow[l].Width < bomb1.Left + bomb1.Width + arrow[l].Width && arrow[l].Bottom <= bomb1.Bottom && arrow[l].Top >= bomb1.Top && bomb1.Visible == true)
                {
                    fata[l] = 0;
                    arrow[l].Visible = false;
                    arrow[l].Location = amove.Location;
                    bomb1.Visible = false;
                    en--;
                }

                if (arrow[l].Left + arrow[l].Width > bomb2.Left && arrow[l].Left + arrow[l].Width < bomb2.Left + bomb2.Width + arrow[l].Width && arrow[l].Bottom <= bomb2.Bottom && arrow[l].Top >= bomb2.Top && bomb2.Visible == true)
                {
                    fata[l] = 0;
                    arrow[l].Visible = false;
                    arrow[l].Location = amove.Location;
                    bomb2.Visible = false;
                    en--;
                }
                if (arrow[l].Left + arrow[l].Width > bug.Left && arrow[l].Left + arrow[l].Width < bug.Left + bug.Width + arrow[l].Width && arrow[l].Bottom <= bug.Bottom && arrow[l].Top >= bug.Top && bug.Visible == true)
                {
                    fata[l] = 0;
                    arrow[l].Visible = false;
                    arrow[l].Location = amove.Location;
                    bug.Visible = false;
                    en--;
                }
                if (arrow[l].Left + arrow[l].Width > monster.Left && arrow[l].Left + arrow[l].Width < monster.Left + monster.Width + arrow[l].Width && arrow[l].Bottom <= monster.Bottom && arrow[l].Top >= monster.Top && monster.Visible == true)
                {
                    fata[l] = 0;
                    arrow[l].Visible = false;
                    arrow[l].Location = amove.Location;
                    monster.Visible = false;
                }
                if (en == 0) proceed.Visible = true;
            }
        }

        private void bomb_Tick(object sender, EventArgs e)
        {
             if (down == false)
            {
                if (bomb1.Top > road2.Location.Y - bomb1.Height - 10)
                {
                    bomb1.Top = road2.Location.Y - bomb1.Height;
                    bomb2.Top = road3.Location.Y - bomb2.Height;
                    down = true;
                }
                else { bomb1.Top += 30; bomb2.Top += 30; }
            }
            else
            {
                if (bomb2.Left > road3.Left + road3.Width - bomb2.Width - 10)
                {
                    b = true;
                    bomb1.Image = Image.FromFile("bomb.jpg");
                    bomb2.Image = Image.FromFile("bomb_left.jpg");
                }
                if (bomb2.Left < road3.Left + bomb2.Width - 10)
                {
                    b = false;
                    bomb1.Image = Image.FromFile("bomb_left.jpg");
                    bomb2.Image = Image.FromFile("bomb.jpg");
                }
                if (b == true)
                {
                    bomb1.Left += 30;
                    bomb2.Left -= 30;
                }

                if (b == false)
                {
                    bomb1.Left -= 30;
                    bomb2.Left += 30;
                }
            }

            if (bug.Top + bug.Height >= road2.Top && bug.Top < road2.Top)
                gaza = false;
            if (bug.Top > road.Location.Y - bug.Height - 5)
            { 
                gaza = true;
                if (bug.Visible == true)
                { beam.Location = bug.Location; beam.Visible = true; }
            }

            if (gaza == true) bug.Top -= 10;
            else bug.Top += 10;

            if (bug.Visible == true)
            {
                beam.Left -= 40;
                if (beam.Left + beam.Width > amove.Left && beam.Left + beam.Width < amove.Left + amove.Width + beam.Width && beam.Bottom <= amove.Bottom && beam.Top >= amove.Top && beam.Visible == true)
                {
                    if (l == 1) care.Visible = true;
                    if (l > 0)
                    {
                        l--; scor.h--;
                        health.Image = Image.FromFile(l + "_heart.jpg");
                        auch.Location = amove.Location;
                        auch.Visible = true;
                    }
                    if (l == 0)
                    {
                        
                        this.DialogResult = DialogResult.Cancel;
                    }
                
                    beam.Visible = false;
                    //else this.DialogResult = DialogResult.Cancel;
                }
            }
            else beam.Visible = false;

            //misca monstrul
            monster.Left -= 20;

            //daca o loveste
            if (amove.Left + amove.Width > monster.Left && amove.Left + amove.Width < monster.Left + monster.Width + amove.Width && amove.Bottom <= monster.Bottom && amove.Top >= monster.Top && monster.Visible == true)
            {
                if (l == 1) care.Visible = true;
                if (l > 0)
                {
                    l--; scor.h--;
                    health.Image = Image.FromFile(l + "_heart.jpg"); 
                    auch.Location = amove.Location;
                    auch.Visible = true;
                }
                if (l == 0)
                {
                    
                    this.DialogResult = DialogResult.Cancel;
                }
                
            }

            auch.Top -= 20;
        }
    }
}
