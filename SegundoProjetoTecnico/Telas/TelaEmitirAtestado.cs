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
    public partial class TelaEmitirAtestado : Form
    {
        public TelaEmitirAtestado()
        {
            InitializeComponent();
        }

        private void btnSalvarAtestado_Click(object sender, EventArgs e)
        {
            Classes.Operacoes operacoes = new Classes.Operacoes();
            operacoes.SalvarArquivo();
        }

        private void salvarEmitirAtestado_Click(object sender, EventArgs e)
        {
            Classes.Operacoes operacoes = new Classes.Operacoes();
            operacoes.SalvarArquivo();
        }
    }
}
