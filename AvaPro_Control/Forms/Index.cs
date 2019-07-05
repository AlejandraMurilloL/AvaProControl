using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entidades;
using Negocio;
using AvaPro_Control.Forms;

namespace AvaPro_Control.Vistas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cpbInicio.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                cpbInicio.Value += 20;   
            }
            catch (Exception)
            {
                timer1.Stop();
                string recordarUsuario = Properties.Settings.Default.Login;
                if (!String.IsNullOrEmpty(recordarUsuario))
                {
                    Users user = new Users();
                    string[] cadena = recordarUsuario.Split(',');
                    user = UsuarioCN.GetUsuarioLogin(cadena[0], cadena[1]);
                    Principal frm = new Principal(user);
                    frm.Show();
                    this.Close();
                }
                else
                {
                    Login frmLogin = new Login();
                    frmLogin.Show();
                    this.Close();
                }
                
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Inicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
