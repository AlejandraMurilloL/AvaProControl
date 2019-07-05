using AvaPro_Control.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaPro_Control.CuadrosDeDialogo
{
    public partial class Completado : Form
    {
        object form; 
        public Completado()
        {
            InitializeComponent();
        }
        public Completado(object form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            timer1.Stop();
            btnAceptar.Visible = true;
            lblCompletado.Visible = true;
            
            
        }

        private void Completado_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Principal frmP = new Principal();
            if (form is Principal)
            {
                frmP.Show();
                this.Close();
            }else frmP.AbrirFormEnPanel(frmP);
        }
    }
}
