using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_COBRO
{
    public partial class Prestamos : Form
    {
        private conexion _conexion;

        public Prestamos()
        {
            InitializeComponent();
            _conexion = new conexion();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
            
            // Configurar evento de búsqueda
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void CargarPrestamos()
        {
            try
            {
                DataTable dt = _conexion.ObtenerPrestamosConCliente();
                
                // Limpiar el DataSource anterior
                dataGridView1.DataSource = null;
                
                // Asignar nuevo DataSource
                dataGridView1.DataSource = dt;

                // Configurar formato de columnas después de asignar el DataSource
                if (dataGridView1.Columns.Count > 0)
                {
                    // Renombrar y configurar columnas
                    if (dataGridView1.Columns["PrestamoID"] != null)
                    {
                        dataGridView1.Columns["PrestamoID"].HeaderText = "ID";
                        dataGridView1.Columns["PrestamoID"].DisplayIndex = 0;
                    }

                    if (dataGridView1.Columns["ClienteID"] != null)
                    {
                        dataGridView1.Columns["ClienteID"].DisplayIndex = 1;
                    }

                    if (dataGridView1.Columns["NombreCliente"] != null)
                    {
                        dataGridView1.Columns["NombreCliente"].HeaderText = "Cliente";
                        dataGridView1.Columns["NombreCliente"].DisplayIndex = 2;
                    }

                    if (dataGridView1.Columns["Cedula"] != null)
                    {
                        dataGridView1.Columns["Cedula"].HeaderText = "Cédula";
                        dataGridView1.Columns["Cedula"].DisplayIndex = 3;
                    }

                    if (dataGridView1.Columns["Monto"] != null)
                    {
                        dataGridView1.Columns["Monto"].HeaderText = "Monto";
                        dataGridView1.Columns["Monto"].DefaultCellStyle.Format = "C2"; // Formato de moneda
                    }

                    if (dataGridView1.Columns["TasaInteres"] != null)
                    {
                        dataGridView1.Columns["TasaInteres"].HeaderText = "Tasa Interés (%)";
                        dataGridView1.Columns["TasaInteres"].DefaultCellStyle.Format = "N2";
                    }

                    if (dataGridView1.Columns["PlazoMeses"] != null)
                    {
                        dataGridView1.Columns["PlazoMeses"].HeaderText = "Plazo (Meses)";
                    }

                    if (dataGridView1.Columns["FechaInicio"] != null)
                    {
                        dataGridView1.Columns["FechaInicio"].HeaderText = "Fecha Inicio";
                        dataGridView1.Columns["FechaInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }

                    if (dataGridView1.Columns["FechaFin"] != null)
                    {
                        dataGridView1.Columns["FechaFin"].HeaderText = "Fecha Fin";
                        dataGridView1.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }

                    if (dataGridView1.Columns["FormaPago"] != null)
                    {
                        dataGridView1.Columns["FormaPago"].HeaderText = "Forma de Pago";
                    }

                    if (dataGridView1.Columns["Estado"] != null)
                    {
                        dataGridView1.Columns["Estado"].HeaderText = "Estado";
                    }

                    // Ajustar ancho de columnas
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string criterio = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(criterio))
            {
                // Si está vacío, cargar todos los préstamos
                CargarPrestamos();
            }
            else
            {
                // Buscar préstamos
                try
                {
                    DataTable dt = _conexion.BuscarPrestamos(criterio);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (NuevoPrestamos nuevoPrestamo = new NuevoPrestamos())
            {
                if (nuevoPrestamo.ShowDialog(this) == DialogResult.OK)
                {
                    // Refrescar la lista después de agregar un nuevo préstamo
                    CargarPrestamos();
                }
            }
        }
    }
}
