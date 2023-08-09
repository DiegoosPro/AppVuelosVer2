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
    public partial class FrmReservacionesVer2 : Form
    {
        public FrmReservacionesVer2()
        {
            InitializeComponent();
        }

        private void tAB_RESERVACIONESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_RESERVACIONESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddvuelosDataSet);

        }

        private void tAB_RESERVACIONESBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_RESERVACIONESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddvuelosDataSet);

        }

        private void FrmReservacionesVer2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_VUELOS' Puede moverla o quitarla según sea necesario.
            this.tAB_VUELOSTableAdapter.Fill(this.bddvuelosDataSet.TAB_VUELOS);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.tAB_CLIENTESTableAdapter.Fill(this.bddvuelosDataSet.TAB_CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.tAB_CLIENTESTableAdapter.Fill(this.bddvuelosDataSet.TAB_CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet2.TAB_TARJETAS_EMBARQUE' Puede moverla o quitarla según sea necesario.
            this.tAB_TARJETAS_EMBARQUETableAdapter.Fill(this.bddvuelosDataSet2.TAB_TARJETAS_EMBARQUE);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_PLAZAS' Puede moverla o quitarla según sea necesario.
            this.tAB_PLAZASTableAdapter.Fill(this.bddvuelosDataSet.TAB_PLAZAS);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_RESERVACIONES' Puede moverla o quitarla según sea necesario.
            this.tAB_RESERVACIONESTableAdapter.Fill(this.bddvuelosDataSet.TAB_RESERVACIONES);

        }
    }
}
