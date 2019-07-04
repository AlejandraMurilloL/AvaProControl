using AvaPro_Control.CuadrosDeDialogo;
using Entidades;
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
    public partial class CambiarContraseña : Form
    {

        private Users user;
        public CambiarContraseña()
        {
            InitializeComponent();
        }

        public CambiarContraseña(Users usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            lblRequerido1.Visible = String.IsNullOrEmpty(txtActual.Text) ? true : false;
            lblRequerido2.Visible = String.IsNullOrEmpty(txtNueva.Text) ? true : false;
            lblRequerido3.Visible = String.IsNullOrEmpty(txtRepetir.Text) ? true : false;

            if (!lblRequerido1.Visible && !lblRequerido2.Visible && !lblRequerido3.Visible)
            {
                if (txtNueva.Text != txtRepetir.Text)
                {
                    lblRequerido3.Text = "Las contraseñas no coinciden";
                    lblRequerido3.Visible = true;
                }
                else
                {
                    user.Password = txtActual.Text;
                    string mensaje = UsuarioCN.CambiarContraseña(user, txtNueva.Text);
                    MessageBoxAceptar MsgBox = new MessageBoxAceptar(mensaje);
                    MsgBox.ShowDialog();
                }                
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNueva_OnValueChanged(object sender, EventArgs e)
        {
            txtNueva.isPassword = true;
        }

        private void txtRepetir_OnValueChanged(object sender, EventArgs e)
        {
            txtRepetir.isPassword = true;
        }
    }
}
