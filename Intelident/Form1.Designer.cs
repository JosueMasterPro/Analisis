﻿
namespace Intelident
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.buttonDev = new FontAwesome.Sharp.IconButton();
            this.comboBoxDev = new System.Windows.Forms.ComboBox();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(335, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(335, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 3;
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
            this.PanelMain.Controls.Add(this.comboBoxDev);
            this.PanelMain.Controls.Add(this.buttonDev);
            this.PanelMain.Controls.Add(this.textBox1);
            this.PanelMain.Controls.Add(this.label3);
            this.PanelMain.Controls.Add(this.textBox2);
            this.PanelMain.Controls.Add(this.label1);
            this.PanelMain.Controls.Add(this.label2);
            this.PanelMain.Controls.Add(this.iconButton2);
            this.PanelMain.Controls.Add(this.iconButton1);
            this.PanelMain.Location = new System.Drawing.Point(0, 194);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(730, 503);
            this.PanelMain.TabIndex = 12;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(391, 283);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(176, 57);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Tag = "";
            this.iconButton2.Text = "Salir";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(165, 283);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(164, 57);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Ingresar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Intelident.Properties.Resources.Intelident;
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
            // buttonDev
            // 
            this.buttonDev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDev.BackColor = System.Drawing.Color.Transparent;
            this.buttonDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDev.FlatAppearance.BorderSize = 0;
            this.buttonDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDev.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDev.IconChar = FontAwesome.Sharp.IconChar.Dev;
            this.buttonDev.IconColor = System.Drawing.Color.Black;
            this.buttonDev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDev.Location = new System.Drawing.Point(675, 15);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(41, 34);
            this.buttonDev.TabIndex = 12;
            this.buttonDev.UseVisualStyleBackColor = false;
            this.buttonDev.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // comboBoxDev
            // 
            this.comboBoxDev.Enabled = false;
            this.comboBoxDev.FormattingEnabled = true;
            this.comboBoxDev.Items.AddRange(new object[] {
            "frank",
            "josue"});
            this.comboBoxDev.Location = new System.Drawing.Point(595, 55);
            this.comboBoxDev.Name = "comboBoxDev";
            this.comboBoxDev.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDev.TabIndex = 13;
            this.comboBoxDev.Visible = false;
            this.comboBoxDev.SelectedValueChanged += new System.EventHandler(this.comboBoxDev_SelectedValueChanged);
            this.comboBoxDev.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxDev_MouseClick);
            // 
            // Form1
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
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelMain;
        private FontAwesome.Sharp.IconButton buttonDev;
        private System.Windows.Forms.ComboBox comboBoxDev;
    }
}

