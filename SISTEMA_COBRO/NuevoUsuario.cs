using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_COBRO
{
    public partial class NuevoUsuario : Form
    {
        private conexion conexionDB;

        public NuevoUsuario()
        {
            InitializeComponent();
            conexionDB = new conexion();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            // Conectar el evento del botón Guardar
            btnGuardar.Click += BtnGuardar_Click;
            
            // Limpiar campos al cargar
            LimpiarCampos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Nota: Según el Designer, hay una confusión en los nombres:
            // - txtContraseña está en la posición del label "Nombre"
            // - txtUsuario está en la posición del label "Contraseña" y tiene PasswordChar
            // - txtEmail está en la posición del label "Email"
            // Por lo tanto:
            string nombre = txtContraseña.Text.Trim();
            string contraseña = txtUsuario.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor ingrese el nombre del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor ingrese la contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (contraseña.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor ingrese el correo electrónico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Validar formato de email
            if (!EsEmailValido(email))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Verificar si el correo ya existe
            if (conexionDB.ExisteCorreo(email))
            {
                MessageBox.Show("El correo electrónico ya está registrado. Por favor use otro correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Insertar el nuevo usuario
            bool exito = conexionDB.InsertarUsuario(nombre, email, contraseña);

            if (exito)
            {
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario. Por favor intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsEmailValido(string email)
        {
            try
            {
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        private void LimpiarCampos()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            txtEmail.Text = "";
            txtContraseña.Focus();
        }
    }
}
