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

        // ===================== CLIENTES =====================

        public bool ExisteClientePorEmail(string email)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Clientes WHERE Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el email del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return existe;
        }

        public bool InsertarCliente(string nombre, string cedula, string telefono, string direccion, string email)
        {
            bool exito = false;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    // Asumimos una tabla Clientes con columnas:
                    // ClienteID (IDENTITY), Nombre, Cedula, Telefono, Direccion, Email
                    string query = "INSERT INTO Clientes (Nombre, Cedula, Telefono, Direccion, Email) VALUES (@Nombre, @Cedula, @Telefono, @Direccion, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Email", email);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        exito = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exito = false;
            }

            return exito;
        }

        public bool ExisteClientePorCedula(string cedula)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Clientes WHERE Cedula = @Cedula";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        existe = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la cédula del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return existe;
        }

        // ===================== PRESTAMOS =====================

        public int ObtenerClienteIDPorCedula(string cedula)
        {
            int clienteID = 0;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ClienteID FROM Clientes WHERE Cedula = @Cedula";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            clienteID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return clienteID;
        }

        public bool InsertarPrestamo(int clienteID, decimal monto, decimal tasaInteres, int plazoMeses, DateTime fechaInicio, string formaPago, string estado)
        {
            bool exito = false;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    // Calcular fecha fin basada en la fecha inicio y plazo en meses
                    DateTime fechaFin = fechaInicio.AddMonths(plazoMeses);

                    string query = @"INSERT INTO Prestamos (ClienteID, Monto, TasaInteres, PlazoMeses, FechaInicio, FechaFin, FormaPago, Estado) 
                                   VALUES (@ClienteID, @Monto, @TasaInteres, @PlazoMeses, @FechaInicio, @FechaFin, @FormaPago, @Estado)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                        cmd.Parameters.AddWithValue("@Monto", monto);
                        cmd.Parameters.AddWithValue("@TasaInteres", tasaInteres);
                        cmd.Parameters.AddWithValue("@PlazoMeses", plazoMeses);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                        cmd.Parameters.AddWithValue("@FormaPago", formaPago ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Estado", estado ?? (object)DBNull.Value);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        exito = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exito = false;
            }

            return exito;
        }

        public DataTable ObtenerPrestamosConCliente()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                                        p.PrestamoID,
                                        p.ClienteID,
                                        c.Nombre AS NombreCliente,
                                        c.Cedula,
                                        p.Monto,
                                        p.TasaInteres,
                                        p.PlazoMeses,
                                        p.FechaInicio,
                                        p.FechaFin,
                                        p.FormaPago,
                                        p.Estado
                                    FROM Prestamos p
                                    INNER JOIN Clientes c ON p.ClienteID = c.ClienteID
                                    ORDER BY p.FechaInicio DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public DataTable BuscarPrestamos(string criterio)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                                        p.PrestamoID,
                                        p.ClienteID,
                                        c.Nombre AS NombreCliente,
                                        c.Cedula,
                                        p.Monto,
                                        p.TasaInteres,
                                        p.PlazoMeses,
                                        p.FechaInicio,
                                        p.FechaFin,
                                        p.FormaPago,
                                        p.Estado
                                    FROM Prestamos p
                                    INNER JOIN Clientes c ON p.ClienteID = c.ClienteID
                                    WHERE c.Nombre LIKE @Criterio 
                                       OR c.Cedula LIKE @Criterio
                                       OR CAST(p.PrestamoID AS VARCHAR) LIKE @Criterio
                                       OR CAST(p.Monto AS VARCHAR) LIKE @Criterio
                                    ORDER BY p.FechaInicio DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
