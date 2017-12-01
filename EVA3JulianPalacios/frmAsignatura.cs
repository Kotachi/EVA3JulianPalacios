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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }

        private void frmAsignatura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lEONESDataSet.Asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.lEONESDataSet.Asignaturas);

        }

        private void btnMostrarIngresoDatos_Click(object sender, EventArgs e)
        {
            frmIngresoDatos ingresoDatos = new frmIngresoDatos();
            ingresoDatos.Show();
            this.Hide();
        }

        private void btnMostrarNotas_Click(object sender, EventArgs e)
        {
            frmNotas notas = new frmNotas();
            notas.Show();
            this.Hide();
        }
    }
}
