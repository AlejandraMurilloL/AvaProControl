using AvaPro_Control.Forms.Categories.BackEnd;
using AvaPro_Control.Forms.FrontEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaPro_Control.Forms.Concepts
{
    public partial class GenericCategories : Form
    {
        public GenericCategories()
        {
            InitializeComponent();
        }        

        private void btnFrontEnd_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new FECategories());
                this.Close();
            }
        }

        private void btnBackEnd_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new BECategories());
                this.Close();
            }
        }
    }
}
