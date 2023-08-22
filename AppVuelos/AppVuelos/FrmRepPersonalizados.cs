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
    public partial class FrmRepPersonalizados : Form
    {
        public FrmRepPersonalizados()
        {
            InitializeComponent();
        }

        private void btnAeropuerto_Click(object sender, EventArgs e)
        {
            FrmRepAeropuertoPais rep = new FrmRepAeropuertoPais();
            rep.ShowDialog();
        }
    }
}
