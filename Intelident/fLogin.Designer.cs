
namespace Intelident
{
    partial class fLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxConstraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.iconButtonSalir = new FontAwesome.Sharp.IconButton();
            this.iconButtonIngresar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUsuario.Location = new System.Drawing.Point(335, 130);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(164, 22);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxConstraseña
            // 
            this.textBoxConstraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxConstraseña.Location = new System.Drawing.Point(335, 177);
            this.textBoxConstraseña.Name = "textBoxConstraseña";
            this.textBoxConstraseña.Size = new System.Drawing.Size(164, 22);
            this.textBoxConstraseña.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 38);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 23);
            this.label3.TabIndex = 11;
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMain.Controls.Add(this.textBoxUsuario);
            this.PanelMain.Controls.Add(this.label3);
            this.PanelMain.Controls.Add(this.textBoxConstraseña);
            this.PanelMain.Controls.Add(this.label1);
            this.PanelMain.Controls.Add(this.label2);
            this.PanelMain.Controls.Add(this.iconButtonSalir);
            this.PanelMain.Controls.Add(this.iconButtonIngresar);
            this.PanelMain.Location = new System.Drawing.Point(0, 194);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(730, 503);
            this.PanelMain.TabIndex = 12;
            // 
            // iconButtonSalir
            // 
            this.iconButtonSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iconButtonSalir.IconColor = System.Drawing.Color.Black;
            this.iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSalir.Location = new System.Drawing.Point(391, 283);
            this.iconButtonSalir.Name = "iconButtonSalir";
            this.iconButtonSalir.Size = new System.Drawing.Size(176, 57);
            this.iconButtonSalir.TabIndex = 8;
            this.iconButtonSalir.Tag = "";
            this.iconButtonSalir.Text = "Salir";
            this.iconButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSalir.UseVisualStyleBackColor = true;
            this.iconButtonSalir.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButtonIngresar
            // 
            this.iconButtonIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonIngresar.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iconButtonIngresar.IconColor = System.Drawing.Color.Black;
            this.iconButtonIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonIngresar.Location = new System.Drawing.Point(165, 283);
            this.iconButtonIngresar.Name = "iconButtonIngresar";
            this.iconButtonIngresar.Size = new System.Drawing.Size(164, 57);
            this.iconButtonIngresar.TabIndex = 7;
            this.iconButtonIngresar.Text = "Ingresar";
            this.iconButtonIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonIngresar.UseVisualStyleBackColor = true;
            this.iconButtonIngresar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            
            this.pictureBox1.Location = new System.Drawing.Point(216, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox2.BackColor = System.Drawing.Color.DarkBlue;
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBox2.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 144;
            this.iconPictureBox2.Location = new System.Drawing.Point(34, 44);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(10);
            this.iconPictureBox2.Size = new System.Drawing.Size(154, 144);
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 144;
            this.iconPictureBox1.Location = new System.Drawing.Point(551, 44);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.iconPictureBox1.Size = new System.Drawing.Size(154, 144);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(730, 697);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxConstraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonIngresar;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelMain;
    }
}

