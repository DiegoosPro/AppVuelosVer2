using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVuelos
{
    public partial class FrmRepClientes : Form
    {
        public FrmRepClientes()
        {
            InitializeComponent();
        }

        private void FrmRepClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet2.TAB_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.TAB_CLIENTESTableAdapter.Fill(this.bddvuelosDataSet2.TAB_CLIENTES);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
