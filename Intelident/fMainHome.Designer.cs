
namespace Intelident
{
    partial class fMainHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainHome));
            this.PanelBarra = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Labelinicio = new System.Windows.Forms.Label();
            this.iconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBoxMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panelMenuMain = new System.Windows.Forms.Panel();
            this.iconButtonConfiguracion = new FontAwesome.Sharp.IconButton();
            this.iconButtonBaseDeDatos = new FontAwesome.Sharp.IconButton();
            this.iconButtonReportes = new FontAwesome.Sharp.IconButton();
            this.iconButtonInventario = new FontAwesome.Sharp.IconButton();
            this.iconButtonRAverias = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelFMainHome = new System.Windows.Forms.Panel();
            this.PanelBarra.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMaximizar)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.panelMenuMain.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarra
            // 
            this.PanelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelBarra.Controls.Add(this.panel4);
            this.PanelBarra.Controls.Add(this.labelUser);
            this.PanelBarra.Controls.Add(this.panel2);
            this.PanelBarra.Controls.Add(this.panel1);
            this.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarra.Location = new System.Drawing.Point(0, 0);
            this.PanelBarra.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.PanelBarra.Name = "PanelBarra";
            this.PanelBarra.Size = new System.Drawing.Size(1488, 150);
            this.PanelBarra.TabIndex = 5;
            this.PanelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarra_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Labelinicio);
            this.panel4.Controls.Add(this.iconCurrent);
            this.panel4.Location = new System.Drawing.Point(384, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 147);
            this.panel4.TabIndex = 10;
            // 
            // Labelinicio
            // 
            this.Labelinicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Labelinicio.AutoSize = true;
            this.Labelinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelinicio.ForeColor = System.Drawing.Color.LightGray;
            this.Labelinicio.Location = new System.Drawing.Point(3, 88);
            this.Labelinicio.Name = "Labelinicio";
            this.Labelinicio.Size = new System.Drawing.Size(48, 20);
            this.Labelinicio.TabIndex = 1;
            this.Labelinicio.Text = "Inicio";
            // 
            // iconCurrent
            // 
            this.iconCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrent.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrent.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconCurrent.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrent.IconSize = 57;
            this.iconCurrent.Location = new System.Drawing.Point(7, 28);
            this.iconCurrent.Name = "iconCurrent";
            this.iconCurrent.Size = new System.Drawing.Size(65, 57);
            this.iconCurrent.TabIndex = 0;
            this.iconCurrent.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(1295, 83);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(38, 17);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1374, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 91);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 91);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.iconPictureBoxMinimizar);
            this.panel1.Controls.Add(this.iconPictureBoxCerrar);
            this.panel1.Controls.Add(this.iconPictureBoxMaximizar);
            this.panel1.Location = new System.Drawing.Point(1335, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 47);
            this.panel1.TabIndex = 6;
            // 
            // iconPictureBoxMinimizar
            // 
            this.iconPictureBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBoxMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBoxMinimizar.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBoxMinimizar.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxMinimizar.Location = new System.Drawing.Point(14, 0);
            this.iconPictureBoxMinimizar.Name = "iconPictureBoxMinimizar";
            this.iconPictureBoxMinimizar.Size = new System.Drawing.Size(32, 43);
            this.iconPictureBoxMinimizar.TabIndex = 4;
            this.iconPictureBoxMinimizar.TabStop = false;
            this.iconPictureBoxMinimizar.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // iconPictureBoxCerrar
            // 
            this.iconPictureBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBoxCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBoxCerrar.ErrorImage = null;
            this.iconPictureBoxCerrar.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBoxCerrar.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCerrar.IconSize = 43;
            this.iconPictureBoxCerrar.InitialImage = null;
            this.iconPictureBoxCerrar.Location = new System.Drawing.Point(102, 0);
            this.iconPictureBoxCerrar.Name = "iconPictureBoxCerrar";
            this.iconPictureBoxCerrar.Size = new System.Drawing.Size(47, 43);
            this.iconPictureBoxCerrar.TabIndex = 2;
            this.iconPictureBoxCerrar.TabStop = false;
            this.iconPictureBoxCerrar.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconPictureBoxMaximizar
            // 
            this.iconPictureBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBoxMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBoxMaximizar.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBoxMaximizar.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBoxMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxMaximizar.IconSize = 43;
            this.iconPictureBoxMaximizar.Location = new System.Drawing.Point(52, 3);
            this.iconPictureBoxMaximizar.Name = "iconPictureBoxMaximizar";
            this.iconPictureBoxMaximizar.Size = new System.Drawing.Size(44, 43);
            this.iconPictureBoxMaximizar.TabIndex = 3;
            this.iconPictureBoxMaximizar.TabStop = false;
            this.iconPictureBoxMaximizar.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.panelLogo);
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(385, 150);
            this.PanelMenu.TabIndex = 7;
            // 
            // panelMenuMain
            // 
            this.panelMenuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelMenuMain.Controls.Add(this.iconButtonConfiguracion);
            this.panelMenuMain.Controls.Add(this.iconButtonBaseDeDatos);
            this.panelMenuMain.Controls.Add(this.iconButtonReportes);
            this.panelMenuMain.Controls.Add(this.iconButtonInventario);
            this.panelMenuMain.Controls.Add(this.iconButtonRAverias);
            this.panelMenuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuMain.Location = new System.Drawing.Point(0, 150);
            this.panelMenuMain.Name = "panelMenuMain";
            this.panelMenuMain.Size = new System.Drawing.Size(385, 803);
            this.panelMenuMain.TabIndex = 0;
            // 
            // iconButtonConfiguracion
            // 
            this.iconButtonConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonConfiguracion.FlatAppearance.BorderSize = 0;
            this.iconButtonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonConfiguracion.ForeColor = System.Drawing.Color.White;
            this.iconButtonConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButtonConfiguracion.IconColor = System.Drawing.Color.White;
            this.iconButtonConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConfiguracion.IconSize = 50;
            this.iconButtonConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConfiguracion.Location = new System.Drawing.Point(0, 288);
            this.iconButtonConfiguracion.Name = "iconButtonConfiguracion";
            this.iconButtonConfiguracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonConfiguracion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonConfiguracion.Size = new System.Drawing.Size(385, 72);
            this.iconButtonConfiguracion.TabIndex = 5;
            this.iconButtonConfiguracion.Text = "Configuración";
            this.iconButtonConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonConfiguracion.UseVisualStyleBackColor = true;
            // 
            // iconButtonBaseDeDatos
            // 
            this.iconButtonBaseDeDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonBaseDeDatos.FlatAppearance.BorderSize = 0;
            this.iconButtonBaseDeDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBaseDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBaseDeDatos.ForeColor = System.Drawing.Color.White;
            this.iconButtonBaseDeDatos.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButtonBaseDeDatos.IconColor = System.Drawing.Color.White;
            this.iconButtonBaseDeDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBaseDeDatos.IconSize = 50;
            this.iconButtonBaseDeDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBaseDeDatos.Location = new System.Drawing.Point(0, 216);
            this.iconButtonBaseDeDatos.Name = "iconButtonBaseDeDatos";
            this.iconButtonBaseDeDatos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonBaseDeDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonBaseDeDatos.Size = new System.Drawing.Size(385, 72);
            this.iconButtonBaseDeDatos.TabIndex = 1;
            this.iconButtonBaseDeDatos.Text = "Base De Datos";
            this.iconButtonBaseDeDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBaseDeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBaseDeDatos.UseVisualStyleBackColor = true;
            // 
            // iconButtonReportes
            // 
            this.iconButtonReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonReportes.FlatAppearance.BorderSize = 0;
            this.iconButtonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReportes.ForeColor = System.Drawing.Color.White;
            this.iconButtonReportes.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.iconButtonReportes.IconColor = System.Drawing.Color.White;
            this.iconButtonReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReportes.IconSize = 50;
            this.iconButtonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReportes.Location = new System.Drawing.Point(0, 144);
            this.iconButtonReportes.Name = "iconButtonReportes";
            this.iconButtonReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonReportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonReportes.Size = new System.Drawing.Size(385, 72);
            this.iconButtonReportes.TabIndex = 4;
            this.iconButtonReportes.Text = "Reportes";
            this.iconButtonReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReportes.UseVisualStyleBackColor = true;
            // 
            // iconButtonInventario
            // 
            this.iconButtonInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonInventario.FlatAppearance.BorderSize = 0;
            this.iconButtonInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonInventario.ForeColor = System.Drawing.Color.White;
            this.iconButtonInventario.IconChar = FontAwesome.Sharp.IconChar.StackOverflow;
            this.iconButtonInventario.IconColor = System.Drawing.Color.White;
            this.iconButtonInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInventario.IconSize = 50;
            this.iconButtonInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonInventario.Location = new System.Drawing.Point(0, 72);
            this.iconButtonInventario.Name = "iconButtonInventario";
            this.iconButtonInventario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonInventario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonInventario.Size = new System.Drawing.Size(385, 72);
            this.iconButtonInventario.TabIndex = 2;
            this.iconButtonInventario.Text = "Inventario";
            this.iconButtonInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonInventario.UseVisualStyleBackColor = true;
            // 
            // iconButtonRAverias
            // 
            this.iconButtonRAverias.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonRAverias.FlatAppearance.BorderSize = 0;
            this.iconButtonRAverias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRAverias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRAverias.ForeColor = System.Drawing.Color.White;
            this.iconButtonRAverias.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconButtonRAverias.IconColor = System.Drawing.Color.White;
            this.iconButtonRAverias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRAverias.IconSize = 50;
            this.iconButtonRAverias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRAverias.Location = new System.Drawing.Point(0, 0);
            this.iconButtonRAverias.Name = "iconButtonRAverias";
            this.iconButtonRAverias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonRAverias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonRAverias.Size = new System.Drawing.Size(385, 72);
            this.iconButtonRAverias.TabIndex = 3;
            this.iconButtonRAverias.Text = "R.Averias";
            this.iconButtonRAverias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRAverias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRAverias.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelLogo.Controls.Add(this.pictureBox3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(385, 150);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Intelident.Properties.Resources.Intelident;
            this.pictureBox3.Location = new System.Drawing.Point(56, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panelFMainHome
            // 
            this.panelFMainHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelFMainHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFMainHome.Location = new System.Drawing.Point(385, 150);
            this.panelFMainHome.Name = "panelFMainHome";
            this.panelFMainHome.Size = new System.Drawing.Size(1103, 803);
            this.panelFMainHome.TabIndex = 8;
            // 
            // fMainHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 953);
            this.Controls.Add(this.panelFMainHome);
            this.Controls.Add(this.panelMenuMain);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelBarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMainHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz";
            this.PanelBarra.ResumeLayout(false);
            this.PanelBarra.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMaximizar)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.panelMenuMain.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxMaximizar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCerrar;
        private System.Windows.Forms.Panel PanelBarra;
        private System.Windows.Forms.Label Labelinicio;
        private FontAwesome.Sharp.IconPictureBox iconCurrent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelMenuMain;
        private FontAwesome.Sharp.IconButton iconButtonConfiguracion;
        private FontAwesome.Sharp.IconButton iconButtonBaseDeDatos;
        private FontAwesome.Sharp.IconButton iconButtonReportes;
        private FontAwesome.Sharp.IconButton iconButtonInventario;
        private FontAwesome.Sharp.IconButton iconButtonRAverias;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelFMainHome;
    }
}