namespace AvaPro_Control.Forms.User
{
    partial class CambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContraseña));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtActual = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNueva = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRepetir = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCambiar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRequerido1 = new System.Windows.Forms.Label();
            this.lblRequerido2 = new System.Windows.Forms.Label();
            this.lblRequerido3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 35);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(480, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtActual
            // 
            this.txtActual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActual.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActual.ForeColor = System.Drawing.Color.White;
            this.txtActual.HintForeColor = System.Drawing.Color.White;
            this.txtActual.HintText = "";
            this.txtActual.isPassword = true;
            this.txtActual.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.txtActual.LineIdleColor = System.Drawing.Color.White;
            this.txtActual.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.txtActual.LineThickness = 3;
            this.txtActual.Location = new System.Drawing.Point(184, 107);
            this.txtActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(271, 33);
            this.txtActual.TabIndex = 9;
            this.txtActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNueva
            // 
            this.txtNueva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNueva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNueva.ForeColor = System.Drawing.Color.White;
            this.txtNueva.HintForeColor = System.Drawing.Color.White;
            this.txtNueva.HintText = "";
            this.txtNueva.isPassword = true;
            this.txtNueva.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.txtNueva.LineIdleColor = System.Drawing.Color.White;
            this.txtNueva.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.txtNueva.LineThickness = 3;
            this.txtNueva.Location = new System.Drawing.Point(184, 173);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(271, 33);
            this.txtNueva.TabIndex = 10;
            this.txtNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNueva.OnValueChanged += new System.EventHandler(this.txtNueva_OnValueChanged);
            // 
            // txtRepetir
            // 
            this.txtRepetir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepetir.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRepetir.ForeColor = System.Drawing.Color.White;
            this.txtRepetir.HintForeColor = System.Drawing.Color.White;
            this.txtRepetir.HintText = "";
            this.txtRepetir.isPassword = true;
            this.txtRepetir.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.txtRepetir.LineIdleColor = System.Drawing.Color.White;
            this.txtRepetir.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.txtRepetir.LineThickness = 3;
            this.txtRepetir.Location = new System.Drawing.Point(184, 240);
            this.txtRepetir.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.Size = new System.Drawing.Size(271, 33);
            this.txtRepetir.TabIndex = 11;
            this.txtRepetir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepetir.OnValueChanged += new System.EventHandler(this.txtRepetir_OnValueChanged);
            // 
            // btnCambiar
            // 
            this.btnCambiar.ActiveBorderThickness = 1;
            this.btnCambiar.ActiveCornerRadius = 20;
            this.btnCambiar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.btnCambiar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCambiar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.btnCambiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambiar.BackgroundImage")));
            this.btnCambiar.ButtonText = "Cambiar";
            this.btnCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.White;
            this.btnCambiar.IdleBorderThickness = 1;
            this.btnCambiar.IdleCornerRadius = 20;
            this.btnCambiar.IdleFillColor = System.Drawing.Color.White;
            this.btnCambiar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.btnCambiar.IdleLineColor = System.Drawing.Color.White;
            this.btnCambiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCambiar.Location = new System.Drawing.Point(58, 302);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(181, 41);
            this.btnCambiar.TabIndex = 15;
            this.btnCambiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.btnCancelar.IdleLineColor = System.Drawing.Color.White;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(270, 302);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 41);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(29, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Contraseña Actual:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(137, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cambio de Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(29, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contraseña Nueva:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(29, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Repetir Contraseña:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRequerido1
            // 
            this.lblRequerido1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.lblRequerido1.Location = new System.Drawing.Point(243, 144);
            this.lblRequerido1.Name = "lblRequerido1";
            this.lblRequerido1.Size = new System.Drawing.Size(183, 23);
            this.lblRequerido1.TabIndex = 20;
            this.lblRequerido1.Text = "Por favor complete el campo";
            this.lblRequerido1.Visible = false;
            // 
            // lblRequerido2
            // 
            this.lblRequerido2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.lblRequerido2.Location = new System.Drawing.Point(243, 210);
            this.lblRequerido2.Name = "lblRequerido2";
            this.lblRequerido2.Size = new System.Drawing.Size(183, 23);
            this.lblRequerido2.TabIndex = 21;
            this.lblRequerido2.Text = "Por favor complete el campo";
            this.lblRequerido2.Visible = false;
            // 
            // lblRequerido3
            // 
            this.lblRequerido3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerido3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.lblRequerido3.Location = new System.Drawing.Point(243, 274);
            this.lblRequerido3.Name = "lblRequerido3";
            this.lblRequerido3.Size = new System.Drawing.Size(183, 23);
            this.lblRequerido3.TabIndex = 22;
            this.lblRequerido3.Text = "Por favor complete el campo";
            this.lblRequerido3.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 10);
            this.panel3.TabIndex = 23;
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(513, 379);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblRequerido3);
            this.Controls.Add(this.lblRequerido2);
            this.Controls.Add(this.lblRequerido1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CambiarContraseña";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtActual;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNueva;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRepetir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCambiar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRequerido1;
        private System.Windows.Forms.Label lblRequerido2;
        private System.Windows.Forms.Label lblRequerido3;
        private System.Windows.Forms.Panel panel3;
    }
}