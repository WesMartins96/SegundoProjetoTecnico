using SegundoProjetoTecnico.Telas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProjetoTecnico.Classes
{
    public class Operacoes
    {
        
        public void SalvarArquivo()
        {
            TelaEmitirAtestado telaEmitirAtestado = new TelaEmitirAtestado();
            File.WriteAllText(@"C:\Arquivos\Atestado_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt", telaEmitirAtestado.txtAtestadoMedico.Text);
            MessageBox.Show("Arquivo Salvo e Enviado Para Impressão");
        }

       

    }
}
