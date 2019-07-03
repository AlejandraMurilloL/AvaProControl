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
using System.Drawing.Drawing2D;
using Entidades;
using Negocio;
using AvaPro_Control.Forms;
using AvaPro_Control.CuadrosDeDialogo;

namespace AvaPro_Control.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword._TextBox.PasswordChar = '•';
        }

        public int xClick = 0, yClick = 0;

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
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
        
        
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle myRectangle = button1.ClientRectangle;
            myRectangle.Inflate(0,30);
            buttonPath.AddEllipse(myRectangle);
            button1.Region = new Region(buttonPath);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user = UsuarioCN.GetUsuarioLogin(txtUsuario._TextBox.Text, txtPassword._TextBox.Text);
            if (user != null)
            {
                if (cbRecordarme.Checked)
                {
                    Properties.Settings.Default["Login"] = user.User+","+ txtPassword._TextBox.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default["Login"] = "";
                    Properties.Settings.Default.Save();
                }
                Principal frm = new Principal(user);
                frm.Show();
                this.Close();
            }
            else
            {
                lblError.Visible = true;
                txtUsuario.text = "";
                txtPassword.text = "";
               
            }
        }


       
    }
}
