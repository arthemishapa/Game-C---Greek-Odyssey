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
    public partial class movie : Form
    {
        public movie()
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
            if (i <= 106)
            {
                if (i <= 101)
                    pictureBox1.Image = Image.FromFile(i + ".jpg");
                i++;
            }
            else this.DialogResult = DialogResult.Cancel;

        }

       

        private void skip_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
