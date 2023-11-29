namespace ProyectoLugComics.Forms
{
    partial class frmPagoFinal
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnPagoFinal = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtDomicilio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreTitular = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTarjeta = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNumeroTarjeta = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdbDebito = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbCredito = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCantArticulos = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCloseLogin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtUserLogueadoName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.btnPagoFinal);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.guna2RadioButton1);
            this.guna2GroupBox1.Controls.Add(this.guna2RadioButton2);
            this.guna2GroupBox1.Controls.Add(this.txtDomicilio);
            this.guna2GroupBox1.Controls.Add(this.txtNombreTitular);
            this.guna2GroupBox1.Controls.Add(this.cmbTarjeta);
            this.guna2GroupBox1.Controls.Add(this.txtNumeroTarjeta);
            this.guna2GroupBox1.Controls.Add(this.rdbDebito);
            this.guna2GroupBox1.Controls.Add(this.rdbCredito);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.txtTotalAPagar);
            this.guna2GroupBox1.Controls.Add(this.txtCantArticulos);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(178, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(661, 611);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Resumen";
            // 
            // btnPagoFinal
            // 
            this.btnPagoFinal.Animated = true;
            this.btnPagoFinal.BackColor = System.Drawing.Color.Transparent;
            this.btnPagoFinal.BorderRadius = 10;
            this.btnPagoFinal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPagoFinal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPagoFinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPagoFinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPagoFinal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPagoFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoFinal.ForeColor = System.Drawing.Color.White;
            this.btnPagoFinal.IndicateFocus = true;
            this.btnPagoFinal.Location = new System.Drawing.Point(243, 520);
            this.btnPagoFinal.Name = "btnPagoFinal";
            this.btnPagoFinal.Size = new System.Drawing.Size(180, 45);
            this.btnPagoFinal.TabIndex = 11;
            this.btnPagoFinal.Text = "Pagar";
            this.btnPagoFinal.UseTransparentBackground = true;
            this.btnPagoFinal.Click += new System.EventHandler(this.btnPagoFinal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "$1000";
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.Checked = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2RadioButton1.Location = new System.Drawing.Point(272, 456);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(119, 19);
            this.guna2RadioButton1.TabIndex = 8;
            this.guna2RadioButton1.TabStop = true;
            this.guna2RadioButton1.Text = "Retiro En Sucursal";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UseVisualStyleBackColor = false;
            this.guna2RadioButton1.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2RadioButton2.Location = new System.Drawing.Point(272, 420);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(108, 19);
            this.guna2RadioButton2.TabIndex = 9;
            this.guna2RadioButton2.Text = "Envio Domicilio";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UseVisualStyleBackColor = false;
            this.guna2RadioButton2.CheckedChanged += new System.EventHandler(this.guna2RadioButton2_CheckedChanged);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BorderRadius = 10;
            this.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDomicilio.DefaultText = "";
            this.txtDomicilio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDomicilio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDomicilio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDomicilio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDomicilio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDomicilio.ForeColor = System.Drawing.Color.Black;
            this.txtDomicilio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDomicilio.Location = new System.Drawing.Point(159, 377);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PasswordChar = '\0';
            this.txtDomicilio.PlaceholderText = "Domicilio";
            this.txtDomicilio.SelectedText = "";
            this.txtDomicilio.Size = new System.Drawing.Size(335, 25);
            this.txtDomicilio.TabIndex = 7;
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.BorderRadius = 10;
            this.txtNombreTitular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreTitular.DefaultText = "";
            this.txtNombreTitular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreTitular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreTitular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreTitular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreTitular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreTitular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreTitular.ForeColor = System.Drawing.Color.Black;
            this.txtNombreTitular.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreTitular.Location = new System.Drawing.Point(159, 336);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.PasswordChar = '\0';
            this.txtNombreTitular.PlaceholderText = "Nombre Titular Tarjeta";
            this.txtNombreTitular.SelectedText = "";
            this.txtNombreTitular.Size = new System.Drawing.Size(335, 25);
            this.txtNombreTitular.TabIndex = 6;
            this.txtNombreTitular.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.cmbTarjeta.BorderColor = System.Drawing.Color.Black;
            this.cmbTarjeta.BorderRadius = 10;
            this.cmbTarjeta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjeta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTarjeta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTarjeta.ForeColor = System.Drawing.Color.Black;
            this.cmbTarjeta.ItemHeight = 30;
            this.cmbTarjeta.Items.AddRange(new object[] {
            "VISA",
            "MASTERCARD"});
            this.cmbTarjeta.Location = new System.Drawing.Point(159, 280);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(335, 36);
            this.cmbTarjeta.TabIndex = 5;
            this.cmbTarjeta.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.BorderRadius = 10;
            this.txtNumeroTarjeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroTarjeta.DefaultText = "";
            this.txtNumeroTarjeta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroTarjeta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroTarjeta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroTarjeta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroTarjeta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumeroTarjeta.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroTarjeta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(159, 237);
            this.txtNumeroTarjeta.MaxLength = 16;
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.PasswordChar = '\0';
            this.txtNumeroTarjeta.PlaceholderText = "Numero Tarjeta";
            this.txtNumeroTarjeta.SelectedText = "";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(335, 25);
            this.txtNumeroTarjeta.TabIndex = 4;
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.BackColor = System.Drawing.Color.Transparent;
            this.rdbDebito.Checked = true;
            this.rdbDebito.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdbDebito.CheckedState.BorderThickness = 0;
            this.rdbDebito.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdbDebito.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbDebito.CheckedState.InnerOffset = -4;
            this.rdbDebito.ForeColor = System.Drawing.Color.Black;
            this.rdbDebito.Location = new System.Drawing.Point(272, 197);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(97, 19);
            this.rdbDebito.TabIndex = 3;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "Tarjeta Debito";
            this.rdbDebito.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbDebito.UncheckedState.BorderThickness = 2;
            this.rdbDebito.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbDebito.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbDebito.UseVisualStyleBackColor = false;
            this.rdbDebito.CheckedChanged += new System.EventHandler(this.rdbDebito_CheckedChanged);
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.BackColor = System.Drawing.Color.Transparent;
            this.rdbCredito.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdbCredito.CheckedState.BorderThickness = 0;
            this.rdbCredito.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdbCredito.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbCredito.CheckedState.InnerOffset = -4;
            this.rdbCredito.ForeColor = System.Drawing.Color.Black;
            this.rdbCredito.Location = new System.Drawing.Point(272, 161);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(101, 19);
            this.rdbCredito.TabIndex = 3;
            this.rdbCredito.Text = "Tarjeta Credito";
            this.rdbCredito.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbCredito.UncheckedState.BorderThickness = 2;
            this.rdbCredito.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbCredito.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbCredito.UseVisualStyleBackColor = false;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad articulos";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.BorderRadius = 10;
            this.txtTotalAPagar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAPagar.DefaultText = "";
            this.txtTotalAPagar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAPagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAPagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAPagar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAPagar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAPagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalAPagar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAPagar.Location = new System.Drawing.Point(240, 121);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.PasswordChar = '\0';
            this.txtTotalAPagar.PlaceholderText = "";
            this.txtTotalAPagar.ReadOnly = true;
            this.txtTotalAPagar.SelectedText = "";
            this.txtTotalAPagar.Size = new System.Drawing.Size(167, 25);
            this.txtTotalAPagar.TabIndex = 0;
            // 
            // txtCantArticulos
            // 
            this.txtCantArticulos.BorderRadius = 10;
            this.txtCantArticulos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantArticulos.DefaultText = "";
            this.txtCantArticulos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantArticulos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantArticulos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantArticulos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantArticulos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantArticulos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantArticulos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantArticulos.Location = new System.Drawing.Point(240, 64);
            this.txtCantArticulos.Name = "txtCantArticulos";
            this.txtCantArticulos.PasswordChar = '\0';
            this.txtCantArticulos.PlaceholderText = "";
            this.txtCantArticulos.ReadOnly = true;
            this.txtCantArticulos.SelectedText = "";
            this.txtCantArticulos.Size = new System.Drawing.Size(167, 25);
            this.txtCantArticulos.TabIndex = 0;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BorderThickness = 1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton1.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton1.Location = new System.Drawing.Point(952, 12);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(28, 28);
            this.guna2CircleButton1.TabIndex = 11;
            this.guna2CircleButton1.Text = "-";
            this.guna2CircleButton1.UseTransparentBackground = true;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnCloseLogin.BorderThickness = 1;
            this.btnCloseLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseLogin.FillColor = System.Drawing.Color.Red;
            this.btnCloseLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseLogin.ForeColor = System.Drawing.Color.White;
            this.btnCloseLogin.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnCloseLogin.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btnCloseLogin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCloseLogin.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLogin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCloseLogin.Location = new System.Drawing.Point(986, 12);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloseLogin.Size = new System.Drawing.Size(28, 28);
            this.btnCloseLogin.TabIndex = 10;
            this.btnCloseLogin.Text = "X";
            this.btnCloseLogin.UseTransparentBackground = true;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // txtUserLogueadoName
            // 
            this.txtUserLogueadoName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserLogueadoName.BorderColor = System.Drawing.Color.Black;
            this.txtUserLogueadoName.BorderRadius = 10;
            this.txtUserLogueadoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserLogueadoName.DefaultText = "";
            this.txtUserLogueadoName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserLogueadoName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserLogueadoName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserLogueadoName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserLogueadoName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserLogueadoName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserLogueadoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserLogueadoName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserLogueadoName.Location = new System.Drawing.Point(12, 12);
            this.txtUserLogueadoName.Name = "txtUserLogueadoName";
            this.txtUserLogueadoName.PasswordChar = '\0';
            this.txtUserLogueadoName.PlaceholderText = "";
            this.txtUserLogueadoName.SelectedText = "";
            this.txtUserLogueadoName.Size = new System.Drawing.Size(146, 32);
            this.txtUserLogueadoName.TabIndex = 12;
            // 
            // frmPagoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 649);
            this.Controls.Add(this.txtUserLogueadoName);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "frmPagoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagoFinal";
            this.Load += new System.EventHandler(this.frmPagoFinal_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rdbCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAPagar;
        private Guna.UI2.WinForms.Guna2TextBox txtCantArticulos;
        private Guna.UI2.WinForms.Guna2RadioButton rdbDebito;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroTarjeta;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTarjeta;
        private Guna.UI2.WinForms.Guna2TextBox txtDomicilio;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreTitular;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnPagoFinal;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCloseLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUserLogueadoName;
    }
}