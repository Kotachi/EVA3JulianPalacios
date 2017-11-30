using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVA3JulianPalacios
{
    public partial class frmMostrarDatos : Form
    {
        public frmMostrarDatos()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmIngresoDatos principal = new frmIngresoDatos();
            principal.Show();
            this.Hide();
        }
    }
}
