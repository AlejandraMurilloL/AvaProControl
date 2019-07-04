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
    public partial class Edit : Form
    {

        private Users usuarioActivo = new Users();

        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Users user)
        {
            InitializeComponent();
            usuarioActivo = user;
            txtNombres.Text = usuarioActivo.FirstName;
            txtApellidos.Text = usuarioActivo.LastName;
            txtEmail.Text = usuarioActivo.Email;
            txtUsuario.Text = usuarioActivo.User;
            txtOcupacion.Text = usuarioActivo.Ocupation;
            txtPerfil.Text = usuarioActivo.Profile;
            cmbGenero.selectedIndex = (usuarioActivo.Gender == "F") ? 0 : 1;            
            pbImagen.Image = UserHelper.ByteToImageArray(usuarioActivo.ProfilePicture);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.BackColor = Color.White;

        }
        
        private Users ObtenerDatosFormulario()
        {
            Users usuarioEditado = new Users();
            usuarioEditado.UserID = usuarioActivo.UserID;
            usuarioEditado.FirstName = txtNombres.Text;
            usuarioEditado.LastName = txtApellidos.Text;
            usuarioEditado.Email = txtEmail.Text;
            usuarioEditado.User = txtUsuario.Text;
            usuarioEditado.Ocupation = txtOcupacion.Text;
            usuarioEditado.Gender = cmbGenero.selectedValue;
            usuarioEditado.Profile = txtPerfil.Text;
            usuarioEditado.Password = usuarioActivo.Password;
            usuarioEditado.ProfilePicture = UserHelper.ImageToByteArray(pbImagen.Image);
            return usuarioEditado;
        }


        private void cmbGenero_onItemSelected(object sender, EventArgs e)
        {
            if (cmbGenero.selectedValue == "F")
            {
                if (pbImagen.Image == Properties.Resources.perfilHombre)
                {
                    pbImagen.Image = Properties.Resources.perfilMujer;
                }
                
            }
            else
            {
                if (pbImagen.Image == Properties.Resources.perfilMujer)
                {
                    pbImagen.Image = Properties.Resources.perfilHombre;
                }
            }
        }

        private void btnSeleccionarImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagen.ImageLocation = getImage.FileName;
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuardar_Click_2(object sender, EventArgs e)
        {

            if (txtNombres.Text == string.Empty || txtApellidos.Text == string.Empty || txtEmail.Text == string.Empty || txtUsuario.Text == string.Empty )
            {
                lblRequerido.Visible = true;
            }
            else
            {
                lblRequerido.Visible = false;
                if (UserHelper.ValidarEmail(txtEmail.Text))
                {
                    lblCorreo.Visible = false;
                    bool guardadoExitoso;
                    Users usuarioEditado = ObtenerDatosFormulario();
                    guardadoExitoso = UsuarioCN.SaveUser(usuarioEditado);
                    if (guardadoExitoso)
                    {
                        MessageBoxAceptar MsgBox = new MessageBoxAceptar("Los cambios se guardaron correctamente");
                        MsgBox.ShowDialog();
                        Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
                        if (frmPrincipal != null)
                        {
                            frmPrincipal.MostrarDatosUsuario(usuarioEditado);
                        }

                    }
                    else
                    {
                        MessageBoxAceptar MsgBox = new MessageBoxAceptar("Hubó un error al guardar los cambios, por favor intente nuevamente. \n Si el error persiste por favor contacte con el administrador.");
                        MsgBox.ShowDialog();
                    }
                }
                else
                {
                    lblCorreo.Visible = true;
                }
               
            }
            
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseña frmCambiar = new CambiarContraseña(usuarioActivo);
            frmCambiar.ShowDialog();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            crearCirculoIMG();
        }

        public void crearCirculoIMG()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbImagen.Width, pbImagen.Height);
            Region rg = new Region(gp);
            pbImagen.Region = rg;
        }
    }
}
