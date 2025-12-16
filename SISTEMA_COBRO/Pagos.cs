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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaPrestamosDBDataSet.Prestamos' table. You can move, or remove it, as needed.
            this.prestamosTableAdapter.Fill(this.sistemaPrestamosDBDataSet.Prestamos);

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Validate selection
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un préstamo en la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate amount
            decimal montoPago;
            if (!decimal.TryParse(txtPagar.Text.Trim(), out montoPago) || montoPago <= 0)
            {
                MessageBox.Show("Ingrese un monto válido mayor que 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagar.Focus();
                return;
            }

            // Get row data
            var row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            if (row == null)
            {
                MessageBox.Show("No se pudo leer el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int prestamoID = Convert.ToInt32(row["PrestamoID"]);

            // Current monto and plazo
            decimal montoActual = Convert.ToDecimal(row["Monto"]);
            int plazoActual = Convert.ToInt32(row["PlazoMeses"]);

            // Apply payment: subtract montoPago from Monto (balance). Also decrease plazo by 1 month (minimum 0)
            decimal nuevoMonto = montoActual - montoPago;
            if (nuevoMonto < 0) nuevoMonto = 0;

            int nuevoPlazo = plazoActual - 1;
            if (nuevoPlazo < 0) nuevoPlazo = 0;

            // Update DataRow
            row.BeginEdit();
            row["Monto"] = nuevoMonto;
            row["PlazoMeses"] = nuevoPlazo;
            row.EndEdit();

            // Update database via TableAdapter
            try
            {
                this.Validate();
                this.prestamosBindingSource.EndEdit();
                this.prestamosTableAdapter.Update(this.sistemaPrestamosDBDataSet.Prestamos);

                MessageBox.Show("Pago aplicado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh dataset and grid
                this.prestamosTableAdapter.Fill(this.sistemaPrestamosDBDataSet.Prestamos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPagar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
