namespace ProyectoLugComics.UserControls
{
    partial class ucHome
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserControl = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtUserControl
            // 
            this.txtUserControl.BackColor = System.Drawing.Color.Transparent;
            this.txtUserControl.BorderColor = System.Drawing.Color.Black;
            this.txtUserControl.BorderRadius = 10;
            this.txtUserControl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserControl.DefaultText = "";
            this.txtUserControl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserControl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserControl.FillColor = System.Drawing.Color.Thistle;
            this.txtUserControl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserControl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserControl.Location = new System.Drawing.Point(3, 3);
            this.txtUserControl.Name = "txtUserControl";
            this.txtUserControl.PasswordChar = '\0';
            this.txtUserControl.PlaceholderText = "";
            this.txtUserControl.ReadOnly = true;
            this.txtUserControl.SelectedText = "";
            this.txtUserControl.Size = new System.Drawing.Size(167, 32);
            this.txtUserControl.TabIndex = 18;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtUserControl);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(176, 40);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtUserControl;
    }
}
