using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_emerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.gatin;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.negao;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.cha;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.tri;
        }

        private void bt2_MouseHover(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.gatin;
        }

        private void bt3_MouseHover(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.cha;
        }

        private void bt4_MouseHover(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.negao;
        }

        private void bt5_MouseHover(object sender, EventArgs e)
        {
            pcima.Image = Properties.Resources.tri;
        }

















        //botão "Não Há Animal"
        private void bt1_Click(object sender, EventArgs e)
        {
            string nome = tx1.Text ;

            MessageBox.Show("Animal Digitado é:" + nome, "\nNão ha Aimais!!!!");
        }
       
        private void tx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
