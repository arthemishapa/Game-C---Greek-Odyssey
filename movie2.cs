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
    public partial class movie2 : Form
    {
        public movie2()
        {
            InitializeComponent();
            Timer m_timer = new Timer();
            m_timer.Interval = 300;
            m_timer.Tick += new EventHandler(m_timer_Tick);
            m_timer.Enabled = true;
        }
        int i = 1;
        private void m_timer_Tick(object sender, EventArgs e)
        {
            if (i <= 74)
            {
                if (i <= 69)
                
                    pictureBox1.Image = Image.FromFile("m_" + i + ".jpg");
                    i++;
                
                
            }
            else { this.DialogResult = DialogResult.Cancel; //this.Close(); 
            }
        }

        private void skip_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.Cancel;
                //this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
    }
}
