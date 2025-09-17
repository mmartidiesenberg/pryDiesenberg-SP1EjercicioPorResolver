using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenberg_SP1EjercicioPorResolver
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int intentos = 0;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if ((usuario == "Adm" && contraseña == "@1a") ||
                (usuario == "John" && contraseña == "*2b") ||
                (usuario == "Ceci" && contraseña == "*@3c") ||
                (usuario == "God" && contraseña == "*@#4d"))
            {
                this.Hide();
                frmLogin f = new frmLogin();
                f.Text = usuario; // muestra el nombre del usuario en el título
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
        }
    }
}




