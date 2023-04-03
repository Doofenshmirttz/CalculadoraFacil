using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmLogin : Form
    {
        Dictionary<string, string> Usuarios = new Dictionary<string, string>()
        {
            {"Breiddy","breiddy05"},
            {"Francisco","Francisco06"}
        };

       



    public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbClave.Text == Usuarios[txtbUsuario.Text])
                {
                    MessageBox.Show("Usted ha accedido");
                }
                

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Credeciales incorrectas");
            }
            
        }

        private void txtbClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }
    }
}
