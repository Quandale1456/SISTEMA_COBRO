using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_COBRO
{
    public partial class NuevoPrestamos : Form
    {
        private readonly conexion _conexion;

        public NuevoPrestamos()
        {
            InitializeComponent();
            _conexion = new conexion();
        }

        private void NuevoPrestamos_Load(object sender, EventArgs e)
        {
            // Conectar el evento del botón Guardar
            btnGuardar.Click += BtnGuardar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener datos del cliente
            string cedula = txtCedula.Text.Trim();

            // Validar cédula
            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Por favor ingrese la cédula del cliente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return;
            }

            // Obtener ClienteID
            int clienteID = _conexion.ObtenerClienteIDPorCedula(cedula);
            if (clienteID == 0)
            {
                MessageBox.Show("No se encontró un cliente con esa cédula. Por favor verifique la cédula o registre el cliente primero.", "Cliente no encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCedula.Focus();
                return;
            }

            // Obtener datos del préstamo
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Por favor ingrese el monto del préstamo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

            if (!decimal.TryParse(textBox4.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor ingrese un monto válido mayor a cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor ingrese la tasa de interés.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            if (!decimal.TryParse(textBox3.Text, out decimal tasaInteres) || tasaInteres < 0)
            {
                MessageBox.Show("Por favor ingrese una tasa de interés válida.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor ingrese el plazo en meses.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text, out int plazoMeses) || plazoMeses <= 0)
            {
                MessageBox.Show("Por favor ingrese un plazo válido mayor a cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            // Fecha de inicio (hoy)
            DateTime fechaInicio = DateTime.Now;

            // Forma de pago (opcional, puede estar vacío)
            string formaPago = string.IsNullOrWhiteSpace(textBox1.Text) ? "Mensual" : textBox1.Text.Trim();

            // Estado por defecto
            string estado = "Activo";

            // Insertar préstamo
            bool exito = _conexion.InsertarPrestamo(clienteID, monto, tasaInteres, plazoMeses, fechaInicio, formaPago, estado);

            if (exito)
            {
                MessageBox.Show("Préstamo registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el préstamo. Intente nuevamente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            // Cuando se ingresa la cédula, buscar y llenar los datos del cliente
            string cedula = txtCedula.Text.Trim();
            if (!string.IsNullOrWhiteSpace(cedula) && cedula.Length >= 8)
            {
                CargarDatosCliente(cedula);
            }
        }

        private void CargarDatosCliente(string cedula)
        {
            try
            {
                using (var conn = _conexion.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Nombre, Telefono, Direccion FROM Clientes WHERE Cedula = @Cedula";

                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombre.Text = reader["Nombre"].ToString();
                                txtTelefono.Text = reader["Telefono"].ToString();
                                txtDireccion.Text = reader["Direccion"].ToString();
                            }
                            else
                            {
                                // Limpiar campos si no se encuentra el cliente
                                txtNombre.Text = "";
                                txtTelefono.Text = "";
                                txtDireccion.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // No mostrar error, solo no cargar datos
                System.Diagnostics.Debug.WriteLine("Error al cargar datos del cliente: " + ex.Message);
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
