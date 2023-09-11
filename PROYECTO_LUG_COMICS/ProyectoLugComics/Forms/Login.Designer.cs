namespace ProyectoLugComics
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
            this.btnCloseLogin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarse = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLogin.BorderThickness = 1;
            this.btnCloseLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseLogin.FillColor = System.Drawing.Color.LightCoral;
            this.btnCloseLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseLogin.ForeColor = System.Drawing.Color.White;
            this.btnCloseLogin.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnCloseLogin.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btnCloseLogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCloseLogin.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLogin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCloseLogin.Location = new System.Drawing.Point(454, 12);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloseLogin.Size = new System.Drawing.Size(28, 28);
            this.btnCloseLogin.TabIndex = 1;
            this.btnCloseLogin.Text = "X";
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(134, 41);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(81, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 89);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(81, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderRadius = 5;
            this.btnIngresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresar.FillColor = System.Drawing.Color.LightGreen;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(46, 135);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(169, 19);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarse.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegistrarse.BorderRadius = 5;
            this.btnRegistrarse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrarse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarse.FillColor = System.Drawing.Color.LightBlue;
            this.btnRegistrarse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(72, 160);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(119, 19);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(81, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(53, 15);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "UserName";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(81, 79);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(49, 15);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Password";
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ContainerControl1.BorderColor = System.Drawing.Color.White;
            this.guna2ContainerControl1.BorderRadius = 5;
            this.guna2ContainerControl1.BorderThickness = 2;
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2ContainerControl1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2ContainerControl1.Controls.Add(this.btnRegistrarse);
            this.guna2ContainerControl1.Controls.Add(this.txtUsername);
            this.guna2ContainerControl1.Controls.Add(this.txtPassword);
            this.guna2ContainerControl1.Controls.Add(this.btnIngresar);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(122, 98);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(256, 200);
            this.guna2ContainerControl1.TabIndex = 5;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Hack Nerd Font Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(33, 94);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(59, 15);
            this.guna2HtmlLabel4.TabIndex = 5;
            this.guna2HtmlLabel4.Text = "Password";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Hack Nerd Font Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(33, 46);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(59, 15);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "UserName";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Location = new System.Drawing.Point(180, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(132, 69);
            this.guna2Panel1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnCloseLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarse;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

