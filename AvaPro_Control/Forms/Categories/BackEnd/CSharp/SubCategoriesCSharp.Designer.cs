namespace AvaPro_Control.Forms.Categories.BackEnd.CSharp
{
    partial class SubCategoriesCSharp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualStudio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisualStudio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(83)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(752, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Visual Studio";
            // 
            // btnVisualStudio
            // 
            this.btnVisualStudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisualStudio.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualStudio.Image = global::AvaPro_Control.Properties.Resources.visualStudioLogo;
            this.btnVisualStudio.InitialImage = global::AvaPro_Control.Properties.Resources.html5Logo;
            this.btnVisualStudio.Location = new System.Drawing.Point(756, 453);
            this.btnVisualStudio.Name = "btnVisualStudio";
            this.btnVisualStudio.Size = new System.Drawing.Size(100, 100);
            this.btnVisualStudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVisualStudio.TabIndex = 6;
            this.btnVisualStudio.TabStop = false;
            // 
            // SubCategoriesCSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisualStudio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubCategoriesCSharp";
            this.Text = "SubCategoriesCSharp";
            ((System.ComponentModel.ISupportInitialize)(this.btnVisualStudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnVisualStudio;
    }
}