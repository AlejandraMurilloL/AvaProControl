using AvaPro_Control.Forms.Categories.BackEnd.CSharp;
using AvaPro_Control.Forms.Categories.BackEnd.Java;
using AvaPro_Control.Forms.Categories.BackEnd.Php;
using AvaPro_Control.Forms.Categories.BackEnd.Python;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaPro_Control.Forms.Categories.BackEnd
{
    public partial class BECategories : Form
    {
        public BECategories()
        {
            InitializeComponent();
        }

        private void btnCSharp_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new SubCategoriesCSharp());
                this.Close();
            }
        }

        private void btnJava_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new SubCategoriesJava());
                this.Close();
            }
        }

        private void btnPython_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new SubCategoriesPython());
                this.Close();
            }
        }

        private void btnPhp_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = Application.OpenForms.OfType<Principal>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new SubCategoriesPhp());
                this.Close();
            }
        }
    }
}
