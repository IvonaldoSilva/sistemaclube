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
    public partial class RelatorioDependente : Form
    {
        public RelatorioDependente()
        {
            InitializeComponent();
        }

        private void FrmRelatorioDep_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbldependenteTableAdapter.Fill(this.ClubeDataSet.tblDependente,Convert.ToString(txtMatricula.Text));
            this.reportViewer1.RefreshReport();

        }
    }
}
