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
    public partial class game : Form
    {     
        PictureBox[] arrow = new PictureBox[6];

        int[] fata = new int[6];  //tine evidenta sagetilor si directia in care se indreapta
        public game()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
            
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
            amove.Top = screen.Height - amove.Height;
            arrow[1] = arrow1;
            arrow[2] = arrow2;
            arrow[3] = arrow3;
            arrow[4] = arrow4;
            arrow[5] = arrow5;
        }

        int k = 1, sus, i = 0;             // k = index pentru pozele de miscare; 
        bool jump = false;                 // verifica daca personajul sare sau nu
        bool right = true;                 // verifica in ce directie merge personajul
        

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
                        if(jump == false) amove.Image = Image.FromFile("shoot.jpg");
                        arrow[i].Image = Image.FromFile("arrow.jpg");
                        fata[i] = 1;
                    }
                    else
                    { 
                        if(jump == false) amove.Image = Image.FromFile("shoot_left.jpg");
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
        public void move_Tick(object sender, EventArgs e)
        {   //daca sare
            if (jump == true)                                       
            {
                amove.Top -= sus;
                sus -= 5;
                //isi schimba sensul cand sare in functie de stanga sau dreapta
                if (right == true)                                   
                        amove.Image = Image.FromFile("jump.jpg");
                    else amove.Image = Image.FromFile("jump_left.jpg");

            }
            //pozitia pe care o ia dupa ce a cazut
            if (amove.Top + amove.Height >= screen.Height)
            { amove.Top = screen.Height - amove.Height; jump = false;} 
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
                else {
                    amove.Image = Image.FromFile("amove_" + k + "_left.jpg");
                    k++;
                    if (k > 4) k = 1;
                    amove.Image = Image.FromFile("astop_left.jpg");
                    move.Enabled = false;
                }
            }
            if(amove.Right > screen.Right)
                this.DialogResult = DialogResult.Cancel;
        }

        //misca sageata

        public void arrowt_Tick(object sender, EventArgs e)
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
            }
            proceed.Visible = true;
                
        }

        private void game_Load(object sender, EventArgs e)
        {

        }
    }
}
