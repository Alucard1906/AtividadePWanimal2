using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ele_Mentos
{
    public partial class imagen : Form
    {
        public imagen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.rick_astley_removebg_preview;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.hqdefault;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.Rickroll2;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pcb3_MouseHover(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.hqdefault;
        }

        private void pcb2_MouseHover(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.Rickroll2;
        }

        private void pcb1_MouseHover(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.rick_astley_removebg_preview;
        }
    }
}
