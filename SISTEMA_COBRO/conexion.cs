using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SISTEMA_COBRO
{
    public class conexion
    {
        private string connectionString;

        public conexion()
        {
            // Obtener la cadena de conexión desde Settings
            connectionString = Properties.Settings.Default.SistemaPrestamosDBConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DatosGetUsuarios ValidarUsuario(string correo, string contraseña)
        {
            DatosGetUsuarios usuario = null;
            
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Codigo, Nombre, Correo, Contraseña FROM Usuarios WHERE Correo = @Correo AND Contraseña = @Contraseña";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usuario = new DatosGetUsuarios(
                                    reader.GetInt32(0),      // Codigo
                                    reader.GetString(1),     // Nombre
                                    reader.GetString(2),     // Correo
                                    reader.GetString(3)      // Contraseña
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return usuario;
        }

        public bool ExisteCorreo(string correo)
        {
            bool existe = false;
            
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return existe;
        }

        public bool InsertarUsuario(string nombre, string correo, string contraseña)
        {
            bool exito = false;
            
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Usuarios (Nombre, Correo, Contraseña) VALUES (@Nombre, @Correo, @Contraseña)";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        exito = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exito = false;
            }
            
            return exito;
        }
    }
}
