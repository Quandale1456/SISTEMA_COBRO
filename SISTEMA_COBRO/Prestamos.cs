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
        public Prestamos()
        {
            InitializeComponent();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaPrestamosDBDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.sistemaPrestamosDBDataSet.Prestamos);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Prestamos = new NuevoPrestamos();
            Prestamos.Show();

            Prestamos.Visible = true;
            Visible = true;
        }
    }
}
