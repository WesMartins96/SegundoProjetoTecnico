using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProjetoTecnico.Telas
{
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisaCEP_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEP.Text);
                ds.ReadXml(xml);
                txtLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtUF.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!");
            }
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaCadastrar_Load(object sender, EventArgs e)
        {
            TelaCadastrar telaCadastrar = new TelaCadastrar();

            // Exibir Detalhe
            listView1.View = View.Details;
            // Permite Selecionar a linha Toda
            listView1.FullRowSelect = true;
            // Exibe as linhas no ListView
            listView1.GridLines = true;
            // Permite edição de texto
            listView1.LabelEdit = true;

            // Configuração das colunas
            listView1.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Celular", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Email", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Logradouro", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Data de Entrada", 200, HorizontalAlignment.Left);

            telaCadastrar.txtCadastroNome.Select();
        }

        private void btnCadastroConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCadastroNome.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve Digitar o Nome!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!txtCadastroCPF.MaskCompleted)
            {
                MessageBox.Show("Você deve Digitar o CPF!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!txtCadastroCelular.MaskCompleted)
            {
                MessageBox.Show("Você deve Digitar algum Numero para contato!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Definir os itens da lista
            ListViewItem lvi = new ListViewItem(txtCadastroNome.Text.Trim());
            lvi.SubItems.Add(txtCadastroCPF.Text);
            lvi.SubItems.Add(txtCadastroTelefone.Text);
            lvi.SubItems.Add(txtCadastroCelular.Text);
            lvi.SubItems.Add(txtCadastroEmail.Text.Trim());
            lvi.SubItems.Add(txtLogradouro.Text);
            lvi.SubItems.Add(txtDataDeCadastro.Text);

            //Adiciona as Infos criada no listView
            listView1.Items.Add(lvi);

            MessageBox.Show("Dados Cadastrados");
            LimparCampos();
        }

        private void btnCadastroLimpar_Click(object sender, EventArgs e)
        {

            LimparCampos();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void LimparCampos()
        {
            txtCadastroNome.Text = string.Empty;
            txtCadastroCPF.Text = string.Empty;
            txtCadastroTelefone.Text = string.Empty;
            txtCadastroCelular.Text = string.Empty;
            txtDataDeCadastro.Text = string.Empty;
            txtCadastroEmail.Text = string.Empty;

            txtCEP.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtUF.Text = string.Empty;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(0);
        }
    }
}
