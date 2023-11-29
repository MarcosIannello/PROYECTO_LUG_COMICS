namespace ProyectoLugComics.UserControls
{
    partial class ucDetalles
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
            this.btnDetalles = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // btnDetalles
            // 
            this.btnDetalles.Animated = true;
            this.btnDetalles.BorderRadius = 8;
            this.btnDetalles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetalles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetalles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetalles.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetalles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetalles.FillColor = System.Drawing.Color.Purple;
            this.btnDetalles.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnDetalles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetalles.ForeColor = System.Drawing.Color.White;
            this.btnDetalles.Location = new System.Drawing.Point(3, 3);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(180, 45);
            this.btnDetalles.TabIndex = 0;
            this.btnDetalles.Text = "Mostrar detalles";
            // 
            // ucDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetalles);
            this.Name = "ucDetalles";
            this.Size = new System.Drawing.Size(188, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnDetalles;
    }
}
