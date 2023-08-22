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
    public partial class FrmRepClientesVuelos : Form
    {
        public FrmRepClientesVuelos()
        {
            InitializeComponent();
        }

        private void FrmRepClientesVuelos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet2.ClientesVuelos' Puede moverla o quitarla según sea necesario.
            this.ClientesVuelosTableAdapter.FillClientesVuelos(this.bddvuelosDataSet2.ClientesVuelos);

            this.reportViewer1.RefreshReport();
        }
    }
}
