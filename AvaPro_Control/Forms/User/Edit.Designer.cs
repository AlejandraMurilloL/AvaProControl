namespace AvaPro_Control.Forms.User
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbGenero = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtNombres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOcupacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellidos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPerfil = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.lblTitulo.Location = new System.Drawing.Point(406, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Editar Perfil";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGenero.BackColor = System.Drawing.Color.Transparent;
            this.cmbGenero.BorderRadius = 3;
            this.cmbGenero.DisabledColor = System.Drawing.Color.Gray;
            this.cmbGenero.ForeColor = System.Drawing.Color.White;
            this.cmbGenero.Items = new string[] {
        "F",
        "M"};
            this.cmbGenero.Location = new System.Drawing.Point(701, 206);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cmbGenero.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.cmbGenero.selectedIndex = -1;
            this.cmbGenero.Size = new System.Drawing.Size(201, 42);
            this.cmbGenero.TabIndex = 11;
            this.cmbGenero.onItemSelected += new System.EventHandler(this.cmbGenero_onItemSelected);
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtNombres.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombres.HintText = "";
            this.txtNombres.isPassword = false;
            this.txtNombres.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtNombres.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtNombres.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtNombres.LineThickness = 3;
            this.txtNombres.Location = new System.Drawing.Point(362, 83);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(201, 41);
            this.txtNombres.TabIndex = 23;
            this.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(362, 144);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 41);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOcupacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOcupacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtOcupacion.HintForeColor = System.Drawing.Color.Empty;
            this.txtOcupacion.HintText = "";
            this.txtOcupacion.isPassword = false;
            this.txtOcupacion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtOcupacion.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtOcupacion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtOcupacion.LineThickness = 3;
            this.txtOcupacion.Location = new System.Drawing.Point(362, 206);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(201, 41);
            this.txtOcupacion.TabIndex = 29;
            this.txtOcupacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtApellidos.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellidos.HintText = "";
            this.txtApellidos.isPassword = false;
            this.txtApellidos.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtApellidos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtApellidos.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtApellidos.LineThickness = 3;
            this.txtApellidos.Location = new System.Drawing.Point(701, 87);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(201, 41);
            this.txtApellidos.TabIndex = 31;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(701, 144);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 41);
            this.txtUsuario.TabIndex = 33;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPerfil
            // 
            this.txtPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPerfil.AutoScroll = true;
            this.txtPerfil.AutoSize = true;
            this.txtPerfil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtPerfil.HintForeColor = System.Drawing.Color.Empty;
            this.txtPerfil.HintText = "";
            this.txtPerfil.isPassword = false;
            this.txtPerfil.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtPerfil.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.txtPerfil.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.txtPerfil.LineThickness = 3;
            this.txtPerfil.Location = new System.Drawing.Point(351, 297);
            this.txtPerfil.Margin = new System.Windows.Forms.Padding(5);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(540, 124);
            this.txtPerfil.TabIndex = 38;
            this.txtPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnSeleccionarImagen);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.txtPerfil);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOcupacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 543);
            this.panel1.TabIndex = 39;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(435, 456);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 46);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeleccionarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnSeleccionarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarImagen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.btnSeleccionarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarImagen.Image")));
            this.btnSeleccionarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(23, 256);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(199, 35);
            this.btnSeleccionarImagen.TabIndex = 40;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.btnSeleccionarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionarImagen.UseVisualStyleBackColor = false;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click_1);
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbImagen.Location = new System.Drawing.Point(23, 91);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(199, 159);
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(265, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 32);
            this.label8.TabIndex = 37;
            this.label8.Text = "Perfil:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(593, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 32);
            this.label10.TabIndex = 36;
            this.label10.Text = "Género:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(243, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombres:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(243, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(593, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = "Usuario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(243, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ocupación:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(593, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellidos:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 543);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.Text = "Edit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuDropdown cmbGenero;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombres;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOcupacion;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidos;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSeleccionarImagen;
    }
}