﻿namespace pruebaVENTA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            CancelarLogin = new Button();
            AceptarLogin = new Button();
            txtUsuario = new Label();
            txtLogin = new Label();
            txtPassword = new Label();
            textBoxUsuario = new TextBox();
            textboxPassword = new TextBox();
            iconcerrarlogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconcerrarlogin).BeginInit();
            SuspendLayout();
            // 
            // CancelarLogin
            // 
            CancelarLogin.FlatAppearance.BorderSize = 0;
            CancelarLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            CancelarLogin.FlatStyle = FlatStyle.Flat;
            CancelarLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelarLogin.ForeColor = Color.White;
            CancelarLogin.Image = (Image)resources.GetObject("CancelarLogin.Image");
            CancelarLogin.ImageAlign = ContentAlignment.MiddleLeft;
            CancelarLogin.Location = new Point(80, 345);
            CancelarLogin.Margin = new Padding(4, 3, 4, 3);
            CancelarLogin.Name = "CancelarLogin";
            CancelarLogin.Size = new Size(196, 55);
            CancelarLogin.TabIndex = 0;
            CancelarLogin.Text = "Cancelar";
            CancelarLogin.UseVisualStyleBackColor = true;
            CancelarLogin.Click += CancelarLogin_Click;
            // 
            // AceptarLogin
            // 
            AceptarLogin.FlatAppearance.BorderSize = 0;
            AceptarLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            AceptarLogin.FlatStyle = FlatStyle.Flat;
            AceptarLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AceptarLogin.ForeColor = Color.White;
            AceptarLogin.Image = (Image)resources.GetObject("AceptarLogin.Image");
            AceptarLogin.ImageAlign = ContentAlignment.MiddleLeft;
            AceptarLogin.Location = new Point(359, 345);
            AceptarLogin.Margin = new Padding(4, 3, 4, 3);
            AceptarLogin.Name = "AceptarLogin";
            AceptarLogin.Size = new Size(203, 55);
            AceptarLogin.TabIndex = 1;
            AceptarLogin.Text = "Aceptar";
            AceptarLogin.UseVisualStyleBackColor = true;
            AceptarLogin.Click += AceptarLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.AutoSize = true;
            txtUsuario.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(85, 156);
            txtUsuario.Margin = new Padding(4, 0, 4, 0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(115, 33);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario:";
            // 
            // txtLogin
            // 
            txtLogin.AutoSize = true;
            txtLogin.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(226, 19);
            txtLogin.Margin = new Padding(4, 0, 4, 0);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(129, 42);
            txtLogin.TabIndex = 2;
            txtLogin.Text = "LOGIN";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(14, 217);
            txtPassword.Margin = new Padding(4, 0, 4, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 33);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(226, 171);
            textBoxUsuario.Margin = new Padding(4, 3, 4, 3);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(228, 23);
            textBoxUsuario.TabIndex = 4;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // textboxPassword
            // 
            textboxPassword.Location = new Point(226, 232);
            textboxPassword.Margin = new Padding(4, 3, 4, 3);
            textboxPassword.Name = "textboxPassword";
            textboxPassword.PasswordChar = '*';
            textboxPassword.Size = new Size(228, 23);
            textboxPassword.TabIndex = 5;
            textboxPassword.KeyPress += textboxPassword_KeyPress;
            // 
            // iconcerrarlogin
            // 
            iconcerrarlogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcerrarlogin.Image = (Image)resources.GetObject("iconcerrarlogin.Image");
            iconcerrarlogin.Location = new Point(567, 1);
            iconcerrarlogin.Margin = new Padding(4, 3, 4, 3);
            iconcerrarlogin.Name = "iconcerrarlogin";
            iconcerrarlogin.Size = new Size(23, 23);
            iconcerrarlogin.SizeMode = PictureBoxSizeMode.Zoom;
            iconcerrarlogin.TabIndex = 8;
            iconcerrarlogin.TabStop = false;
            iconcerrarlogin.Click += iconcerrarlogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 110);
            ClientSize = new Size(590, 477);
            Controls.Add(iconcerrarlogin);
            Controls.Add(textboxPassword);
            Controls.Add(textBoxUsuario);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtUsuario);
            Controls.Add(AceptarLogin);
            Controls.Add(CancelarLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)iconcerrarlogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CancelarLogin;
        private System.Windows.Forms.Button AceptarLogin;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textboxPassword;
        private PictureBox iconcerrarlogin;
    }
}

