using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Game_menu
{
    public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
            
            StreamReader f = new StreamReader("info.txt");
            string s = f.ReadToEnd();
            info.Text = s;
        }

       Size normal = new Size(167, 53);
       Size big = new Size(180, 60);

        private void Artemis_MouseLeave(object sender, EventArgs e)
        {
            Artemis.Size = normal;
        }

        private void Artemis_MouseHover(object sender, EventArgs e)
        {
            Artemis.Size = big;
        }

        private void Artemis_Click(object sender, EventArgs e)
        {
            scor.h = 3; scor.esc = false;
            MessageBox.Show("In order to complete levels you have to kill every enemy!");
            this.Hide();
            game g = new game();
            movie m = new movie();
            m.ShowDialog();
            if (m.DialogResult == DialogResult.Cancel)
                g.ShowDialog();
            if (g.DialogResult == DialogResult.Cancel)
                if (scor.esc == true) this.Show();
                else
                {
                    stage1 st1 = new stage1();
                    st1.ShowDialog();
                    if (st1.DialogResult == DialogResult.Cancel)
                    {
                        if (scor.esc == true) { this.Show(); }
                        else
                            if (scor.h == 0)
                            {
                                MessageBox.Show("Game over! Unfortunately you died.");
                                this.Show();
                            }
                            else
                            {
                                stage2 st2 = new stage2();
                                st2.ShowDialog();
                                if (st2.DialogResult == DialogResult.Cancel)
                                {
                                    if (scor.esc == true) { this.Show(); }
                                    else
                                        if (scor.h == 0)
                                        {
                                            MessageBox.Show("Game over! Unfortunately you died.");
                                            this.Show();
                                        }
                                        else
                                        {
                                            stage3 st3 = new stage3();
                                            st3.ShowDialog();
                                            if (st3.DialogResult == DialogResult.Cancel)
                                            {
                                                if (scor.esc == true) { this.Show(); }
                                                else
                                                    if (scor.h == 0)
                                                    {
                                                        MessageBox.Show("Game over! Unfortunately you died.");
                                                        this.Show();
                                                    }
                                                    else
                                                    {
                                                        movie2 m2 = new movie2();
                                                        m2.ShowDialog();
                                                        if (m2.DialogResult == DialogResult.Cancel)
                                                        {
                                                            stage4 st4 = new stage4();
                                                            st4.ShowDialog();
                                                            if (st4.DialogResult == DialogResult.Cancel)
                                                            {
                                                                if (scor.esc == true) { this.Show(); }
                                                                else
                                                                    if (scor.h == 0)
                                                                    {
                                                                        MessageBox.Show("Game over! Unfortunately you died.");
                                                                        this.Show();
                                                                    }
                                                                    else
                                                                    {
                                                                        stage5 st5 = new stage5();
                                                                        st5.ShowDialog();
                                                                        if (st5.DialogResult == DialogResult.Cancel)
                                                                        {
                                                                            if (scor.esc == true) { this.Show(); }
                                                                            else
                                                                                if (scor.h == 0)
                                                                                {
                                                                                    MessageBox.Show("Game over! Unfortunately you died.");
                                                                                    this.Show();
                                                                                }
                                                                                else
                                                                                {
                                                                                    stage6 st6 = new stage6();
                                                                                    st6.ShowDialog();
                                                                                    if (st6.DialogResult == DialogResult.Cancel)
                                                                                    {
                                                                                        if (scor.esc == true) { this.Show(); }
                                                                                        else
                                                                                            if (scor.h == 0)
                                                                                            {
                                                                                                MessageBox.Show("Game over! Unfortunately you died.");
                                                                                                this.Show();
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                final f = new final();
                                                                                                f.ShowDialog();
                                                                                                if (f.DialogResult == DialogResult.Cancel)
                                                                                                {
                                                                                                    MessageBox.Show("Congratulations! You freed Zeus and managed to get his thunderbolt back!");
                                                                                                    this.Show();
                                                                                                }
                                                                                            }
                                                                                    }
                                                                                }
                                                                        }
                                                                    }
                                                            }
                                                        }
                                                    }
                                            }
                                        }
                                }
                            }
                    }
                }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.Size = normal;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.Size = big;
        }

    }
       
}

