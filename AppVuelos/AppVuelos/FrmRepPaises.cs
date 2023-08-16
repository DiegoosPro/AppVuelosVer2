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
    public partial class FrmRepPaises : Form
    {
        public FrmRepPaises()
        {
            InitializeComponent();
        }

        private void FrmRepPaises_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet2.TAB_PAISES' Puede moverla o quitarla según sea necesario.
            this.TAB_PAISESTableAdapter.Fill(this.bddvuelosDataSet2.TAB_PAISES);

            this.reportViewer1.RefreshReport();
        }
    }
}
