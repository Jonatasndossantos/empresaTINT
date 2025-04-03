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
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();
            AdicionarDados();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }//fim consultar

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Codigo";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "telefone";
            dataGridView1.Columns[3].Name = "endereco";
        }
        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//nao pode adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//nao pode apagarlinhas
            dataGridView1.AllowUserToResizeColumns = false;//nao pode redimencionar
            dataGridView1.AllowUserToResizeRows = false;//nao pode redimencionar

            dataGridView1.ColumnCount = 4;//nao pode redimencionar
        }// fim metodo config

        public void AdicionarDados()
        {
            consul.PreencherVetor();//preencher vetor com dados do banco
            for(int i = 0; i < consul.QuantidadeDeDados(); i ++)
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.nome[i], consul.telefone[i], consul.endereco[i]);
            }//fim for
        }//fim metodo adicionar

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
