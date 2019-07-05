using AvaPro_Control.Forms.Categories.FrontEnd;
using AvaPro_Control.Forms.Categories.FrontEnd.Css3;
using AvaPro_Control.Forms.Categories.FrontEnd.JavaScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaPro_Control.Forms.FrontEnd
{
    public partial class FECategories : Form
    {
        public FECategories()
        {
            InitializeComponent();
        }

        private void btnCss_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new SubCategoriesCss());
                this.Close();
            }
        }

        private void btnJavascript_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new SubCategoriesJs());
                this.Close();
            }
        }

        private void btnEditores_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new CodeEditors());
                this.Close();
            }
        }
    }
}
