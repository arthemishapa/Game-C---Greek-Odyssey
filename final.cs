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
    public partial class final : Form
    {
        public final()
        {
            InitializeComponent();

            amove.Top = screen.Height - amove.Height;

            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);

            //timer pentru animatie

            Timer move = new Timer();
            move.Tick += new EventHandler(move_Tick);
            move.Interval = 1000;
            move.Enabled = false;
        }

        int k = 1, up = 40, sus;                    // k = index pentru pozele de miscare; up = cat sare de fiecare data;
        bool jump = false;                          // verifica daca personajul sare sau nu
        bool right = true;                          // verifica in ce directie merge personajul


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
                    right = true;
                    move.Enabled = true;
                    amove.Left += 10;
                    break;
                case Keys.Up:
                    if (jump == false)
                    {
                        sus = up;
                        jump = true;
                    }
                    move.Enabled = true;
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void move_Tick(object sender, EventArgs e)
        {
            if (jump == true)                                       //daca sare
            {
                amove.Top -= sus;
                sus -= 5;
                if (right == true)                                   //isi schimba sensul cand sare in functie de stanga sau dreapta
                    amove.Image = Image.FromFile("jump.jpg");
                else amove.Image = Image.FromFile("jump_left.jpg");

            }
            if (amove.Top + amove.Height >= screen.Height)
            { amove.Top = screen.Height - amove.Height; jump = false; } //pozitia pe care o ia dupa ce a cazut
            else
                amove.Top += 5;   //cade

            if (jump == false)    //daca nu sare executa miscarea normala in functie de stanga/dreapta
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

            if(amove.Left>zeus.Left)
                this.DialogResult = DialogResult.Cancel;
        }                          
    }
}
