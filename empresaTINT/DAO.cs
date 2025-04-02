using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace empresaTINT
{
    class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public DAO() //constructor
        {
            conexao= new MySqlConnection("server=localhost;Database=tintCSharp;Uid=root;password=");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado!!");
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!!\n\n\n"+erro);
            }
        }//fim constructor

        public string Inserir(int codigo,string nome,string telefone,string endereco)
        {
            string inserir = $"insert into pessoa(codigo,nome,telefone,endereco)value('{codigo}','{nome}','{telefone}','{endereco}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() +"Executados";
            return resultado;
        }//fim inserir

        public void PreencherVetor()
        {
            string query = "select * from pessoa";
            //instanciar
            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];

            //prepara o comando para o banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //chamar o leitor do BD
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0; //instancia

            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";

                i++;
            }//fim while

            leitura.Close();
        }
    }//fim da class
}//fim do projeto
