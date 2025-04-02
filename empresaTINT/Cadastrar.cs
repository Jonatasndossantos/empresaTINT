using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace empresaTINT
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAO inserir = new DAO();

            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            MessageBox.Show(inserir.Inserir(codigo,nome,telefone,endereco));
            this.Close();
        }//fim btn cadastrar

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim caixa codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim caixa nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim caixa telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim caixa endereco
    }
}
