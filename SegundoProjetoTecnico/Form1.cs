using SegundoProjetoTecnico.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProjetoTecnico
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            var telaCadastro = new TelaCadastrar();
            telaCadastro.ShowDialog();

        }

        

        private void atestadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEmitirAtestado telaEmitirAtestado =  new TelaEmitirAtestado();
            telaEmitirAtestado.ShowDialog();    
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaSobre telaSobre = new TelaSobre();
            telaSobre.ShowDialog();
        }

        private void sairDaAplicacao_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaHora();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizaHora();
        }

        private void AtualizaHora()
        {
            lblDiaHoraAtual.Text = "Dia e Hora Atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        
    }
}
