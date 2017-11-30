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
    public partial class frmIngresoDatos : Form
    {
        public frmIngresoDatos()
        {
            InitializeComponent();
        }

        Conexion con = new Conexion();
        DateTime fechaNota;

        private void dtpFechaNota_ValueChanged(object sender, EventArgs e)
        {
            fechaNota = dtpFechaNota.Value;
            
        }

        //Menus agregar datos**************************************************

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            con.AgregarAlumno(txtIngRut.Text, txtIngNombre.Text, txtIngEmail.Text);
            limpiar();
        }

        private void mnAgregarNota_Click(object sender, EventArgs e)
        {
            try
            {
                float Nota = Convert.ToSingle(txtNota.Text);
                float Nota2 = Convert.ToSingle(txtIngNota2.Text);
                float Nota3 = Convert.ToSingle(txtIngNota3.Text);
                con.agregarNota(txtIngRut.Text, txtIngCodAsignatura.Text, Nota, Nota2, Nota3, fechaNota);
            }
            catch (FormatException FE)
            {
                MessageBox.Show(FE.Message);
            }
            //MessageBox.Show(fechaNota.ToShortDateString());
           
            limpiar();
        }

        private void mnAgregarAsignatura_Click(object sender, EventArgs e)
        {
            con.agregarAsignatura(txtIngCodAsignatura.Text, txtIngDescAsignatura.Text);
            limpiar();
        }

        private void mnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (verificarRut(txtIngRut.Text) == true)
            {
                con.AgregarAlumno(txtIngRut.Text, txtIngNombre.Text, txtIngEmail.Text);
                limpiar();
            }
            else
            {
                MessageBox.Show("Ingrese un rut valido");
                limpiar();
            }
        }

        public void limpiar()
        {
            txtIngCodAsignatura.Text = txtIngDescAsignatura.Text = txtIngRut.Text = txtIngNombre.Text = txtIngEmail.Text = txtNota.Text = txtIngNota2.Text = txtIngNota3.Text = txtIngNuevoRut.Text = txtIngNCodAsignatura.Text = "";
            dtpFechaNota.ResetText();
        }

        //Metodos de los radiobuttons******************************************

        private void rbAsignatura_CheckedChanged(object sender, EventArgs e)
        {
            lbCodAsignatura.Visible = true;
            txtIngCodAsignatura.Visible = true;
            lbDescAsignatura.Visible = true;
            txtIngDescAsignatura.Visible = true;
            lbCodAsignatura.Visible = true;
            txtIngNCodAsignatura.Visible = true;

            lbIngNombre.Visible = false;
            lbIngRut.Visible = false;
            lbIngEmail.Visible = false;
            txtIngEmail.Visible = false;
            txtIngNombre.Visible = false;
            txtIngRut.Visible = false;

            lbIngFechaNota.Visible = false;
            lbIngNota.Visible = false;
            lbIngNota2.Visible = false;
            lbIngNota3.Visible = false;
            txtNota.Visible = false;
            txtIngNota2.Visible = false;
            txtIngNota3.Visible = false;
            dtpFechaNota.Visible = false;
        }

        private void rbAlumno_CheckedChanged(object sender, EventArgs e)
        {
            lbIngNombre.Visible = true;
            lbIngRut.Visible = true;
            lbIngEmail.Visible = true;
            txtIngEmail.Visible = true;
            txtIngNombre.Visible = true;
            txtIngRut.Visible = true;

            lbCodAsignatura.Visible = false;
            txtIngCodAsignatura.Visible = false;
            lbDescAsignatura.Visible = false;
            txtIngDescAsignatura.Visible = false;
            lbCodAsignatura.Visible = false;
            txtIngNCodAsignatura.Visible = false;

            lbIngFechaNota.Visible = false;
            lbIngNota.Visible = false;
            lbIngNota2.Visible = false;
            lbIngNota3.Visible = false;
            txtNota.Visible = false;
            txtIngNota2.Visible = false;
            txtIngNota3.Visible = false;
            dtpFechaNota.Visible = false;
        }

        private void rbNota_CheckedChanged(object sender, EventArgs e)
        {
            lbIngFechaNota.Visible = true;
            lbIngNota.Visible = true;
            lbIngNota2.Visible = true;
            lbIngNota3.Visible = true;
            txtNota.Visible = true;
            txtIngNota2.Visible = true;
            txtIngNota3.Visible = true;
            dtpFechaNota.Visible = true;

            lbIngRut.Visible = true;
            lbIngEmail.Visible = false;
            lbIngNombre.Visible = false;
            txtIngRut.Visible = true;
            txtIngEmail.Visible = false;
            txtIngNombre.Visible = false;

            lbCodAsignatura.Visible = true;
            lbDescAsignatura.Visible = false;
            txtIngCodAsignatura.Visible = true;
            txtIngDescAsignatura.Visible = false;
            lbCodAsignatura.Visible = false;
            txtIngNCodAsignatura.Visible = false;

        }

       //Metodo verificar RUT*************************************************

        private Boolean verificarRut (String rutVer)
          {
            Boolean rutCorrecto = false;
            String rut = rutVer;
            //revisar cuando no se ingresan datos
            String[] rutProvStr = new String[rut.Length-1];
            int i, x, m = 2, suma = 0, dV = 0;
            int DV1 = Convert.ToInt32(Convert.ToString(rut.ElementAt(rut.Length-1)));
            try
            {  //filtrar. Se quitan los caracteres 		 innecesarios
                for (i = 0, x = 0; i < rut.Length; i++, x++)
                {

                    if (rut.ElementAt(i) != '.' && rut.ElementAt(i) != '-')
                    {
                        rutProvStr[x] = Convert.ToString(rut.ElementAt(i));
                    }
                    else { x--; }

                }
                //Declaracion de una variable tipo num para guardar el resultado rut
                int[] rutProvInt = new int[x];
                //Se hace el calculo de modulo 11
                i = 0;
                for (int y = (x - 2); y >= 0; y--)
                {
                    if (m > 7) { m = 2; }
                    rutProvInt[i] = Convert.ToInt32(Convert.ToString(rutProvStr[y])) * m;
                    m++;
                    suma = suma + rutProvInt[i];
                    i++;
                }
                dV = suma % 11;
                dV = 11 - dV;
                if (dV == 10 && rut.Last().Equals("K") || rut.Last().Equals("k"))
                {
                    MessageBox.Show( "el Digito verificador es valido");
                    rutCorrecto = true;
                }
                else
                {
                    if (dV == 11 && DV1 == 0)
                    {
                        MessageBox.Show( "el Digito verificador es valido");
                        rutCorrecto = true;
                    }
                    else
                    {
                        if (dV == Convert.ToInt32(DV1))
                        {
                            MessageBox.Show ("el Digito verificador es valido");
                            rutCorrecto = true;
                        }
                        else
                        {
                            MessageBox.Show("Digito verificador invalido");
                        }
                    }
                }
            }
            catch (System.FormatException s)
            {
                MessageBox.Show ("formato o rut invalido \n" + s);
            }
            return rutCorrecto;
        }

        //Eliminar datos******************************************************
        //Eliminar alumno
        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.eliminarAlumno(txtIngRut.Text);
            con.eliminarNotas(txtIngRut.Text);
            limpiar();
        }

        private void mnEliminarNotas_Click(object sender, EventArgs e)
        {
            con.eliminarNotas(txtIngRut.Text);
            limpiar();
        }

        private void mnEliminarAsignatura_Click(object sender, EventArgs e)
        {
            con.eliminarAsignatura(txtIngCodAsignatura.Text);
            limpiar();
        }

        //Modificar Datos********************************************************

        private void mnModificarRutAlumno_Click(object sender, EventArgs e)
        {
            con.modificarRutAlumno(txtIngRut.Text,txtIngNuevoRut.Text);
            limpiar();
        }

        private void mnModificarAlumno_Click(object sender, EventArgs e)
        {
            txtIngNuevoRut.Visible = true;
            lbIngNuevoRut.Visible = true;
        }

        private void mnModificarNombreAlumno_Click(object sender, EventArgs e)
        {
            con.modificarNombreAlumno(txtIngRut.Text, txtIngNombre.Text);
            limpiar();
        }

        private void mnModificarEmailAlumno_Click(object sender, EventArgs e)
        {
            con.modificarEmail(txtIngNombre.Text, txtIngEmail.Text);
            limpiar();
        }

        private void mnModificarTodo_Click(object sender, EventArgs e)
        {
            con.ModificarTodoAlumno(txtIngRut.Text, txtIngNombre.Text, txtIngEmail.Text, txtIngNuevoRut.Text);
        }

        private void mnModificarAsignatura_Click(object sender, EventArgs e)
        {
            con.ModificarAsignatura(txtIngCodAsignatura.Text, txtIngDescAsignatura.Text, txtIngNCodAsignatura.Text);
            limpiar();
        }

        private void mnModificarNota1_Click(object sender, EventArgs e)
        {
            String codAsignatura = cbIngNotas.SelectedText ;
            
            float nota1 = Convert.ToSingle(txtNota.Text);
            con.modificarNota1(codAsignatura, txtIngRut.Text, nota1);
            limpiar();
        }

        private void mnModificarNota2_Click(object sender, EventArgs e)
        {
            String codAsignatura = cbIngNotas.SelectedText;
            float nota2 = Convert.ToSingle(txtIngNota2.Text);
            con.modificarNota2(codAsignatura, txtIngRut.Text, nota2);
            limpiar();
        }

        private void mnModificarNota3_Click(object sender, EventArgs e)
        {
            String codAsignatura = cbIngNotas.SelectedText;
            float nota3 = Convert.ToSingle(txtIngNota3.Text);
            con.modificarNota3(codAsignatura, txtIngRut.Text, nota3);
            limpiar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrarDatos mostrarDatos = new frmMostrarDatos();
            mostrarDatos.Show();
            this.Hide();
        }

        private void frmIngresoDatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lEONESDataSet.Asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.lEONESDataSet.Asignaturas);

        }

       
    }
}
