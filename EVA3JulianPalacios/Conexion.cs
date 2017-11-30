using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EVA3JulianPalacios
{
    class Conexion
    {
        private SqlConnection conexion;
        private SqlCommand command;
        private String urlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Desktop\\CODIGOS FUENTE\\EVA3JulianPalacios\\EVA3JulianPalacios\\LEONES.mdf;Integrated Security=True";

        public Conexion()
        {
            try
            {
                conexion = new SqlConnection(urlCon);

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void agregarDatos(String RutAlumno, String Nombre, String Email, String CodAsignatura, String DescAsignatura, float Nota, DateTime FechaNota)
        {
            abrirConexion();
            command.Connection = conexion;
            if (RutAlumno != null && Nombre != null && Email != null)
            {
                try
                {

                    command.CommandText = "INSERT INTO Alumnos (rutAlumno,nombreAlumno,email) VALUES (@rutAlumno, @nombreAlumno, @email)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("rutAlumno", RutAlumno);
                    command.Parameters.AddWithValue("nombreAlumno", Nombre);
                    command.Parameters.AddWithValue("email", Email);
                    command.Dispose();
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            else
            {
                MessageBox.Show("No se han ingresado valores para el Rut, Nombre, email");
            }

            if (CodAsignatura != null && DescAsignatura != null)
            {
                try
                {

                    command.CommandText = "INSERT INTO Asignaturas (CodAsignatura,DescAsignatura) VALUES (@CodAsignatura, @DescAsignatura)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("CodAsignatura", CodAsignatura);
                    command.Parameters.AddWithValue("DescAsignatura", DescAsignatura);
                    command.Dispose();
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            else
            {
                MessageBox.Show("No se han ingresado valores para el Codigo asignatura o Descripcion asignatura");
            }
            if (Nota >= 0 && FechaNota != null)
            {
                try
                {

                    command.CommandText = "INSERT INTO Asignaturas (CodAsignatura,DescAsignatura) VALUES (@CodAsignatura, @DescAsignatura)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("CodAsignatura", CodAsignatura);
                    command.Parameters.AddWithValue("DescAsignatura", DescAsignatura);
                    command.Dispose();

                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            else
            {
                MessageBox.Show("No se han ingresado valores para el Codigo asignatura o Descripcion asignatura");
            }
            cerrarConexion();
        }

        public void AgregarAlumno(String RutAlumno, String Nombre, String Email)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("INSERT INTO Alumnos (rutAlumno,nombreAlumno,email) VALUES ('" + RutAlumno + "','" + Nombre + "','" + Email + "')", conexion);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Alumno ingresado");
                }
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void agregarAsignatura(String nomAsignatura, String descAsignatura)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("INSERT INTO Asignaturas (CodAsignatura,DescAsignatura) VALUES ('" + nomAsignatura + "','" + descAsignatura + "')", conexion);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Asignatura ingresada");
                }
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void agregarNota(String RutAlumno, String CodAsignatura, float nota, float nota2, float nota3, DateTime fechaNota)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("INSERT INTO Notas (rutAlumno, CodAsignatura, Nota1, Nota2, Nota3, FechaNota) VALUES ('" + RutAlumno + "','" + CodAsignatura + "'," + nota + "," + nota2 + "," + nota3 + ", @fechaNota )", conexion);
                command.Parameters.AddWithValue("@fechaNota", fechaNota);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Nota ingresada");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void eliminarAlumno(String RutAlumno)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("DELETE FROM Alumnos WHERE rutAlumno = @rutAlumno", conexion);
                command.Parameters.AddWithValue("@rutAlumno", RutAlumno);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Nota ingresada");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void eliminarNotas(String RutAlumno)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("DELETE FROM Notas WHERE rutAlumno = @rutAlumno", conexion);
                command.Parameters.AddWithValue("@rutAlumno", RutAlumno);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Nota ingresada");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void eliminarAsignatura(String CodAsignatura)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("DELETE FROM Asignaturas WHERE CodAsignatura = @CodAsignatura", conexion);
                command.Parameters.AddWithValue("@codAsignatura", CodAsignatura);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Nota ingresada");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void modificarRutAlumno(String RutAlumno, String nuevoRut)
        {

            try
            {
                conexion.Open();
                command = new SqlCommand("UPDATE Alumnos SET rutAlumno = @nuevoRut WHERE rutAlumno = @rutAlumno", conexion);
                command.Parameters.AddWithValue("@nuevoRut", nuevoRut);
                command.Parameters.AddWithValue("@rutAlumno", RutAlumno);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Rut modificado");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void modificarNombreAlumno(String RutAlumno, String NombreAlumno)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("UPDATE Alumnos SET nombreAlumno = @nombreAlumno WHERE rutAlumno = @RutAlumno", conexion);
                command.Parameters.AddWithValue("@nombreAlumno", NombreAlumno);
                command.Parameters.AddWithValue("@RutAlumno", RutAlumno);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Nombre modificado");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void modificarEmail(String RutAlumno, String Email)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("UPDATE Alumnos SET email = @emailAlumno WHERE rutAlumno = @rutAlumno", conexion);
                command.Parameters.AddWithValue("@emailAlumno", Email);
                command.Parameters.AddWithValue("@rutAlumno", RutAlumno);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Email modificado");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void ModificarTodoAlumno(String RutAlumno, String NombreAlumno, String Email, String nuevoRut)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("UPDATE Alumnos SET rutAlumno = @nuevoRut, nombreAlumno = @nombreAlumno, email = @email WHERE rutAlumno = @rutAlumno", conexion);
                command.Parameters.AddWithValue("@nuevoRut", nuevoRut);
                command.Parameters.AddWithValue("@rutAlumno", RutAlumno);
                command.Parameters.AddWithValue("@nombreAlumno", NombreAlumno);
                command.Parameters.AddWithValue("@email", Email);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Datos modificado");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        } 

        public void ModificarAsignatura (String CodAsignatura, String DescAsignatura, String nuevoCodAsignatura)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("UPDATE Asignaturas SET CodAsignatura = @nCodAsignatura, DescAsignatura = @descAsignatura WHERE CodAsignatura = @codAsignatura", conexion);
                command.Parameters.AddWithValue("@nCodAsignatura", nuevoCodAsignatura);
                command.Parameters.AddWithValue("@descAsignatura", DescAsignatura);
                command.Parameters.AddWithValue("@codAsignatura", CodAsignatura);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Asignatura modificado");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void modificarNota1 (String codAsignatura, String RutAlumno, float nota1)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("UPDATE Notas SET Nota1 = @nota1 WHERE rutAlumno = @RutAlumno AND CodAsignatura = @codAsignatura", conexion);
                command.Parameters.AddWithValue("@nota1", nota1);
                command.Parameters.AddWithValue("@RutAlumno", RutAlumno);
                command.Parameters.AddWithValue("@codAsignatura", codAsignatura);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Nota 1 modificada");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void modificarNota2(String codAsignatura, String RutAlumno, float nota2)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("UPDATE Notas SET Nota2 = @nota2 WHERE rutAlumno = @RutAlumno AND CodAsignatura = codAsignatura", conexion);
                command.Parameters.AddWithValue("@nota2", nota2);
                command.Parameters.AddWithValue("@RutAlumno", RutAlumno);
                command.Parameters.AddWithValue("@codAsignatura", codAsignatura);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Nota 2 modificada");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void modificarNota3 (String codAsignatura, String RutAlumno, float nota3)
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("UPDATE Notas SET Nota3 = @nota3 WHERE rutAlumno = @RutAlumno AND CodAsignatura = codAsignatura", conexion);
                command.Parameters.AddWithValue("@nota3", nota3);
                command.Parameters.AddWithValue("@RutAlumno", RutAlumno);
                command.Parameters.AddWithValue("@codAsignatura", codAsignatura);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Nota 3 modificada");
                }
                command.Dispose();
                conexion.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public SqlCommand llenarAlumno ()
        {
            try
            {
                conexion.Open();
                command = new SqlCommand("SELECT * FROM Alumnos )", conexion);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Alumno ingresado");
                    return command;
                }
                else
                {
                    MessageBox.Show("Alumno no encontrado.");
                    return null;
                }
                command.Dispose();
                conexion.Close();
               
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                return null;
            }
        }

    }
}
