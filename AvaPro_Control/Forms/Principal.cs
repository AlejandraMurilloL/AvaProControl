
using AvaPro_Control.Forms.User;
using AvaPro_Control.Vistas;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaPro_Control.Forms
{
    public partial class Principal : Form
    {
        private Users usuarioActual = new Users();
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Users user)
        {
            InitializeComponent();
            usuarioActual = user;
            if (usuarioActual.ProfilePicture == null)
            {
                if (usuarioActual.Gender == "F")
                {
                    usuarioActual.ProfilePicture = UserHelper.ImageToByteArray(Properties.Resources.perfilMujer);
                }
                else
                {
                    usuarioActual.ProfilePicture = UserHelper.ImageToByteArray(Properties.Resources.perfilHombre);
                }
            }
            MostrarDatosUsuario(usuarioActual);


        }

        private void Principal_Load(object sender, EventArgs e)
        {
            crearCirculoIMG();
            AbrirFormEnPanel(new Fondo());
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;            
        }

        public void crearCirculoIMG() {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbFotoPerfil.Width, pbFotoPerfil.Height);
            Region rg = new Region(gp);
            pbFotoPerfil.Region = rg;
        }
        private void pbFotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
        public int xClick = 0, yClick = 0;

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.ColumnStyles[0].Width == 20)
            {
                tableLayoutPanel1.ColumnStyles[0].Width = 5;
                tableLayoutPanel1.ColumnStyles[1].Width = 95;
            
            }
            else
            {
                tableLayoutPanel1.ColumnStyles[0].Width = 20;
                tableLayoutPanel1.ColumnStyles[1].Width = 80;

            }


        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Edit(usuarioActual));
        }

        private void Principal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        int lx, ly;

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 768);
            this.Location = new Point(lx, ly);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {

        }
       
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Fondo());

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Login"] = "";
            Properties.Settings.Default.Save();
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        public void AbrirFormEnPanel(object formHijo)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
            this.Refresh();
        }

        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

        public void MostrarDatosUsuario(Users usuario)
        {
            pbFotoPerfil.Image = UserHelper.ByteToImageArray(usuario.ProfilePicture);
            pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoPerfil.BackColor = Color.White;
            lblNombres.Text = usuario.FirstName + " " + usuario.LastName;
            lblEmail.Text = usuario.Email;
            lblOcupacion.Text = usuario.Ocupation;
        }
    }
}
