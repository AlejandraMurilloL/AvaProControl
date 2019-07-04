using AvaPro_Control.CuadrosDeDialogo;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaPro_Control.Forms.User
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                lblRequerido.Visible = true;
            }
            else
            {
                string mensaje = UsuarioCN.RecuperarContraseña(txtEmail.Text);
                MessageBoxAceptar MsgBox = new MessageBoxAceptar(mensaje);
                MsgBox.ShowDialog();
            }
        }
    }
}
