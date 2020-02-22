using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                cb_nivel.DataSource = bll.Localizar("");
                cb_nivel.DisplayMember = "niv_nome";
                cb_nivel.ValueMember = "niv_cod";
            }
            catch (SqlException exs)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados. \n" +
                                "Acesse a 'Configuração do Banco de Dados' na aba 'Ferramentas' \n" +
                                "e informe os parâmetros de conexão. " + exs.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                int quantidade = bll.LocalizarUsuario(txt_usuario.Text, txt_senha.Text, cb_nivel.SelectedValue.ToString());
                int codigo = bll.LocalizarCodigo(txt_usuario.Text, txt_senha.Text, cb_nivel.SelectedValue.ToString());

                if (quantidade == 1 && codigo > 0)
                {
                    //log de acesso
                    ModeloLogUsuario modelo = new ModeloLogUsuario();
                    modelo.LogTempEntrada = DateTime.Now;
                    modelo.UsuCod = codigo;

                    BLLLogUsuario bllu = new BLLLogUsuario(cx);
                    bllu.Entrada(modelo);

                    frm_principal f = new frm_principal(codigo, modelo.LogCod);
                    f.ShowDialog();
                    f.Dispose();
                }
                else {
                    MessageBox.Show("Usuário não encontrado no banco de dados.");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Um erro ocorreu na busca do usuário. " + erro.Message);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_senha.Clear();
            cb_nivel.SelectedIndex = 0;
        }
    }
}
