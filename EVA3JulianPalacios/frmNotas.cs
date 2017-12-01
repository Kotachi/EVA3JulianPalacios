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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        Conexion conNotas = new Conexion();

        private void frmNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lEONESDataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.lEONESDataSet.Notas);
            

        }

        private void btnMostrarIngreso_Click(object sender, EventArgs e)
        {
            frmIngresoDatos mostrarIngreso = new frmIngresoDatos();
            mostrarIngreso.Show();
            this.Hide();
        }

        private void btnMostrarAsignatura_Click(object sender, EventArgs e)
        {
            frmAsignatura mostrarAsignatura = new frmAsignatura();
            mostrarAsignatura.Show();
            this.Hide();
        }

        private void mostrarDatosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.MostrarDatos(this.lEONESDataSet.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        
        private void btnMostrarPromedio_Click(object sender, EventArgs e)
        {
            
            String mostrarRut = cbMostrarRut.SelectedText;
            String mostrarAsignatura = cbMostrarAsignatura.SelectedText;
            MessageBox.Show(mostrarAsignatura, mostrarRut);
            try
            {
                PromedioNotas(mostrarRut, mostrarAsignatura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }

        public void PromedioNotas(String rutAlumno, String CodAsignatura)
        {
            int limiteDGV = dgvMostrarNotas.Rows.Count;
            float sumNotas=0,promedio=0;
            for (int i=0; i<limiteDGV-1;i++)
            if (dgvMostrarNotas.Rows[i].Cells[i].ToString().Equals(rutAlumno) && dgvMostrarNotas.Rows[i].Cells[i].ToString().Equals(CodAsignatura))
            {
                    for (int y = 2; y < 5; y++)
                    {
                        sumNotas = Convert.ToSingle(dgvMostrarNotas.Rows[i].Cells[y].ToString());
                    }
                    promedio = sumNotas / 3;
                    
                }
                
            if (promedio < 4)
            {
                MessageBox.Show("El promedio del alumno es " + promedio + "\n Reprueba.");
            }
            if (promedio >= 5)
            {
                MessageBox.Show("El promedio del alumno es " + promedio + "\n Aprueba.");
            }
            else if (promedio >= 4 && promedio <= 4.9)
            {
                MessageBox.Show("El promedio del alumno es " + promedio + "\n Presenta examen.");
            }

        }

        //Frecuencia Nota1
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            double frecNota = Convert.ToDouble(txtFrecNotas.Text);
            String codAsignatura = cbMostrarAsignatura.SelectedText;
            this.notasTableAdapter.FrecuenciaNota1(this.lEONESDataSet.Notas,frecNota,codAsignatura);
        }

        private void btnFrecNota2_Click(object sender, EventArgs e)
        {
            double frecNota = Convert.ToDouble(txtFrecNotas.Text);
            String codAsignatura = cbMostrarAsignatura.SelectedText;
            MessageBox.Show(codAsignatura);
            this.notasTableAdapter.FrecuenciaNota2(this.lEONESDataSet.Notas, frecNota, codAsignatura);
        }

        private void btnFrecNota3_Click(object sender, EventArgs e)
        {
            double frecNota = Convert.ToDouble(txtFrecNotas.Text);
            String codAsignatura = cbMostrarAsignatura.SelectedText;
            MessageBox.Show(codAsignatura);
            this.notasTableAdapter.FrecuenciaNota3(this.lEONESDataSet.Notas, frecNota, codAsignatura);
        }
    }
}
