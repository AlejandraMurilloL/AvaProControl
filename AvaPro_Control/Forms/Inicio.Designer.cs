namespace AvaPro_Control.Vistas
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cpbInicio = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // cpbInicio
            // 
            this.cpbInicio.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("cpbInicio.AnimationFunction")));
            this.cpbInicio.AnimationSpeed = 500;
            this.cpbInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cpbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpbInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cpbInicio.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cpbInicio.InnerMargin = 2;
            this.cpbInicio.InnerWidth = -1;
            this.cpbInicio.Location = new System.Drawing.Point(581, 81);
            this.cpbInicio.MarqueeAnimationSpeed = 2000;
            this.cpbInicio.Name = "cpbInicio";
            this.cpbInicio.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cpbInicio.OuterMargin = -25;
            this.cpbInicio.OuterWidth = 26;
            this.cpbInicio.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.cpbInicio.ProgressWidth = 25;
            this.cpbInicio.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbInicio.Size = new System.Drawing.Size(167, 182);
            this.cpbInicio.StartAngle = 270;
            this.cpbInicio.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cpbInicio.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbInicio.SubscriptText = "";
            this.cpbInicio.SuperscriptColor = System.Drawing.Color.White;
            this.cpbInicio.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbInicio.SuperscriptText = "";
            this.cpbInicio.TabIndex = 1;
            this.cpbInicio.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbInicio.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(173)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(329, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "AvaPro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(337, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Control de avances en programación";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Inicio
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpbInicio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inicio_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar cpbInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}