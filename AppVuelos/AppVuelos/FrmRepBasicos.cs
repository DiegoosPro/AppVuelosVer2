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
    public partial class FrmRepBasicos : Form
    {
        public FrmRepBasicos()
        {
            InitializeComponent();
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            FrmRepPaises rep = new FrmRepPaises();
            rep.ShowDialog();
        }
    }
}
