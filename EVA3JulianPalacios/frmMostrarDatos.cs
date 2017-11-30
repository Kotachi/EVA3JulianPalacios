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

        Conexion conAlumno = new Conexion();
       

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmIngresoDatos principal = new frmIngresoDatos();
            principal.Show();
            this.Hide();
        }

        private void frmMostrarDatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lEONESDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.lEONESDataSet.Alumnos);

        }

        private void buscarAlumnoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.alumnosTableAdapter.buscarAlumno(this.lEONESDataSet.Alumnos, rutAlumnoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mnLlenarTabla_Click(object sender, EventArgs e)
        {
            this.alumnosTableAdapter.Fill(this.lEONESDataSet.Alumnos);
        }
    }
}
