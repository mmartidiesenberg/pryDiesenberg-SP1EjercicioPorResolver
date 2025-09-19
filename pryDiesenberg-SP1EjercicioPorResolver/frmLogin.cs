using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenberg_SP1EjercicioPorResolver
{
    public partial class frmLogin : Form
    {
        int intentos = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string moduloSeleccionado = txtModulo.Text;
            string[] modulosPermitidos = null;

            if ((usuario == "Adm" && contraseña == "@1a") ||
                (usuario == "John" && contraseña == "*2b") ||
                (usuario == "Ceci" && contraseña == "*@3c") ||
                (usuario == "God" && contraseña == "*@#4d"))
            {
                
                if (usuario == "Adm")
                {
                    modulosPermitidos = new string[] { "ADM", "COM", "VTA" };
                }
                    
                if (usuario == "John")
                {
                    modulosPermitidos = new string[] { "SIST" };
                }
                    
                if (usuario == "Ceci")
                {
                    modulosPermitidos = new string[] { "ADM", "VTA" };
                }
                    
                if (usuario == "God")
                {
                    modulosPermitidos = new string[] { "ADM", "COM", "VTA", "SIST" };
                }
                    
                if (modulosPermitidos != null && modulosPermitidos.Contains(moduloSeleccionado))
                {
                    this.Hide();
                    frmNavegacion f = new frmNavegacion();
                    f.Text = usuario;
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                    intentos++;
                }
            }
            else
            { 
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++;
                if (intentos >= 3)
                {
                    this.Close();
                }                            
            }
        }
    }
}







