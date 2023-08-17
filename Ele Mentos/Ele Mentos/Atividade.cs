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
    public partial class Atividade : Form
    {
        public Atividade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txt1.Text;

            string idade = txt2.Text;

            string email = txt3.Text;

            string sexo = txt4.Text;

            MessageBox.Show("Nome Digitado é: " + nome+ "\nIdade: "+  idade + "\n Email " + email+ "\n Sexo " + sexo+ "\nCadastro");

            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();


            lblmostra2.Text = "Nome:"+nome + "\nIdade:"+idade + "\nEmail:" + email + "\nSexo:" + sexo  ;



        }

        private void lblmostra2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
