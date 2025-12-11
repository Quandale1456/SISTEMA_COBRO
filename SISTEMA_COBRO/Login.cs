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
    public partial class Login : Form
    {
        private conexion conexionDB;

        public Login()
        {
            InitializeComponent();
            conexionDB = new conexion();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Configurar eventos para los TextBox
            txtusername.Enter += Txtusername_Enter;
            txtusername.Leave += Txtusername_Leave;
            txtpassword.Enter += Txtpassword_Enter;
            txtpassword.Leave += Txtpassword_Leave;
            
            // Configurar eventos para los controles
            btnIniciarSesion.Click += BtnIniciarSesion_Click;
            lblSalir.Click += LblSalir_Click;
            
            // Configurar PasswordChar para el campo de contraseña
            txtpassword.PasswordChar = '*';
        }

        private void Txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "Usuario")
            {
                txtusername.Text = "";
                txtusername.ForeColor = SystemColors.HotTrack;
            }
        }

        private void Txtusername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text))
            {
                txtusername.Text = "Usuario";
                txtusername.ForeColor = SystemColors.HotTrack;
            }
        }

        private void Txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Contraseña")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = SystemColors.HotTrack;
                txtpassword.PasswordChar = '*';
            }
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                txtpassword.Text = "Contraseña";
                txtpassword.ForeColor = SystemColors.HotTrack;
                txtpassword.PasswordChar = '\0';
            }
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txtusername.Text.Trim();
            string contraseña = txtpassword.Text.Trim();

            // Validar que los campos no estén vacíos
            if (correo == "" || correo == "Usuario")
            {
                MessageBox.Show("Por favor ingrese su correo electrónico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }

            if (contraseña == "" || contraseña == "Contraseña")
            {
                MessageBox.Show("Por favor ingrese su contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return;
            }

            // Validar usuario en la base de datos
            DatosGetUsuarios usuario = conexionDB.ValidarUsuario(correo, contraseña);

            if (usuario != null && usuario.Codigo > 0)
            {
                MessageBox.Show($"¡Bienvenido {usuario.Nombre}!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Abrir el formulario principal
                Form1 formPrincipal = new Form1();
                formPrincipal.Show();
                
                // Cerrar el formulario de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos. Por favor verifique sus credenciales.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void LblSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
