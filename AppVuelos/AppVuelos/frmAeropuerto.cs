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
    public partial class frmAeropuerto : Form
    {
        public frmAeropuerto()
        {
            InitializeComponent();
        }

        private void tAB_AEROPUERTOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_AEROPUERTOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddvuelosDataSet);

        }

        private void frmAeropuerto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_CIUDADES' Puede moverla o quitarla según sea necesario.
            this.tAB_CIUDADESTableAdapter.Fill(this.bddvuelosDataSet.TAB_CIUDADES);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_AEROPUERTOS' Puede moverla o quitarla según sea necesario.
            this.tAB_AEROPUERTOSTableAdapter.Fill(this.bddvuelosDataSet.TAB_AEROPUERTOS);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.tAB_AEROPUERTOSTableAdapter.FillByParametros(bddvuelosDataSet.TAB_AEROPUERTOS,
                "%"+txtCodigo.Text+"%", "%"+txtNombre.Text+"%");
        }
    }
}
