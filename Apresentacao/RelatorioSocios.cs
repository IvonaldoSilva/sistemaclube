using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class RelatorioSocios : Form
    {
        public RelatorioSocios()
        {
            InitializeComponent();
        }

        private void RelatorioSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ClubeDataSet.tblPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tblPessoaTableAdapter.Fill(this.ClubeDataSet.tblPessoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
