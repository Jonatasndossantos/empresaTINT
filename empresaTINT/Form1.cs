using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresaTINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }//fim constructor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }//cadastrar

        private void consultar_Click(object sender, EventArgs e)
        {
            Consultar cad = new Consultar();
            cad.ShowDialog();
        }//fim consultar

        private void atualizar_Click(object sender, EventArgs e)
        {
            Atualizar cad = new Atualizar();
            cad.ShowDialog();

        }//fim atualizar

        private void excluir_Click(object sender, EventArgs e)
        {
            Excluir cad = new Excluir();
            cad.ShowDialog();
        }//fim excluir
    }
}
