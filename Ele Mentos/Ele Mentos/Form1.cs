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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btcadastra_Click(object sender, EventArgs e)
        {
            //1° Tenho que pegar o texto que se encontra no textbox
            string nome = txtnome.Text;
            //2°Mostrar a mensagen com nome 
            MessageBox.Show("Nome Digitado é:" + nome, "Cadastro");
            //3°Limpar o Textbox
            txtnome.Clear();
            //txtnome.Text = "";
            //4° Mostrar o label
            lblmostra.Text = nome;
        }
    }
}
