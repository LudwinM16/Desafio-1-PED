using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PED_Desafio1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usuarioRegistro = usuario.Text.Trim();
            string contraEntrada = contrasenia.Text.Trim();
            string usuarioValido;
            string contraValida;


            //capturamos valores 
            if (string.IsNullOrEmpty(usuarioRegistro) || string.IsNullOrEmpty(contraEntrada))
            {
                errorProvider1.SetError(usuario, "Debe ingresar un dato");
                errorProvider1.SetError(contrasenia, "Debe ingresar un dato");
            }
            else
            {
                //se settean las credenciales para ingresar al sistema
                usuarioValido = "Administrador";
                contraValida = "Password";
                if (usuarioRegistro == usuarioValido && contraEntrada == contraValida)
                {
                    this.Hide();
                    Pacientes rgPacientes = new Pacientes();
                    rgPacientes.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales Invalidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuario.Clear();
                    contrasenia.Clear();
                    usuario.Focus();
                }
            }
        }
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
