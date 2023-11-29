namespace ProyectoLugComics
{
    partial class frmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucHome_1 = new ProyectoLugComics.UserControls.ucHome();
            this.gridUltimosMovimientos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnComprarComics = new Guna.UI2.WinForms.Guna2Button();
            this.btnMostrarComics = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseLogin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ucLogout1 = new ProyectoLugComics.UserControls.ucLogout();
            this.btnGenerarXML = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridUltimosMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // ucHome_1
            // 
            this.ucHome_1.BackColor = System.Drawing.Color.Transparent;
            this.ucHome_1.Location = new System.Drawing.Point(12, 12);
            this.ucHome_1.Name = "ucHome_1";
            this.ucHome_1.Size = new System.Drawing.Size(178, 40);
            this.ucHome_1.TabIndex = 10;
            this.ucHome_1.Load += new System.EventHandler(this.ucHome_1_Load);
            // 
            // gridUltimosMovimientos
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gridUltimosMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridUltimosMovimientos.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUltimosMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridUltimosMovimientos.ColumnHeadersHeight = 20;
            this.gridUltimosMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUltimosMovimientos.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridUltimosMovimientos.EnableHeadersVisualStyles = true;
            this.gridUltimosMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridUltimosMovimientos.Location = new System.Drawing.Point(277, 286);
            this.gridUltimosMovimientos.Name = "gridUltimosMovimientos";
            this.gridUltimosMovimientos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUltimosMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridUltimosMovimientos.RowHeadersVisible = false;
            this.gridUltimosMovimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridUltimosMovimientos.Size = new System.Drawing.Size(491, 293);
            this.gridUltimosMovimientos.TabIndex = 9;
            this.gridUltimosMovimientos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridUltimosMovimientos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridUltimosMovimientos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridUltimosMovimientos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridUltimosMovimientos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridUltimosMovimientos.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.gridUltimosMovimientos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridUltimosMovimientos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridUltimosMovimientos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridUltimosMovimientos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridUltimosMovimientos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridUltimosMovimientos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridUltimosMovimientos.ThemeStyle.HeaderStyle.Height = 20;
            this.gridUltimosMovimientos.ThemeStyle.ReadOnly = true;
            this.gridUltimosMovimientos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridUltimosMovimientos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridUltimosMovimientos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridUltimosMovimientos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridUltimosMovimientos.ThemeStyle.RowsStyle.Height = 22;
            this.gridUltimosMovimientos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridUltimosMovimientos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Ultimos movimientos";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(337, 205);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(384, 54);
            this.guna2TextBox1.TabIndex = 8;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // BtnComprarComics
            // 
            this.BtnComprarComics.BackColor = System.Drawing.Color.Transparent;
            this.BtnComprarComics.BorderRadius = 10;
            this.BtnComprarComics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnComprarComics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnComprarComics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnComprarComics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnComprarComics.FillColor = System.Drawing.Color.White;
            this.BtnComprarComics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnComprarComics.ForeColor = System.Drawing.Color.DimGray;
            this.BtnComprarComics.IndicateFocus = true;
            this.BtnComprarComics.Location = new System.Drawing.Point(438, 116);
            this.BtnComprarComics.Name = "BtnComprarComics";
            this.BtnComprarComics.Size = new System.Drawing.Size(180, 45);
            this.BtnComprarComics.TabIndex = 6;
            this.BtnComprarComics.Text = "VER CATALOGO";
            this.BtnComprarComics.UseTransparentBackground = true;
            this.BtnComprarComics.Click += new System.EventHandler(this.BtnComprarComics_Click);
            // 
            // btnMostrarComics
            // 
            this.btnMostrarComics.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarComics.BorderRadius = 10;
            this.btnMostrarComics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMostrarComics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMostrarComics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMostrarComics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMostrarComics.FillColor = System.Drawing.Color.White;
            this.btnMostrarComics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarComics.ForeColor = System.Drawing.Color.DimGray;
            this.btnMostrarComics.IndicateFocus = true;
            this.btnMostrarComics.Location = new System.Drawing.Point(438, 56);
            this.btnMostrarComics.Name = "btnMostrarComics";
            this.btnMostrarComics.Size = new System.Drawing.Size(180, 45);
            this.btnMostrarComics.TabIndex = 6;
            this.btnMostrarComics.Text = "ADMIN COMICS";
            this.btnMostrarComics.UseTransparentBackground = true;
            this.btnMostrarComics.Click += new System.EventHandler(this.btnMostrarComics_Click);
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
            this.btnCloseLogin.Location = new System.Drawing.Point(985, 12);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloseLogin.Size = new System.Drawing.Size(28, 28);
            this.btnCloseLogin.TabIndex = 4;
            this.btnCloseLogin.Text = "X";
            this.btnCloseLogin.UseTransparentBackground = true;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click_1);
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
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Text = "-";
            this.guna2CircleButton1.UseTransparentBackground = true;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // ucLogout1
            // 
            this.ucLogout1.BackColor = System.Drawing.Color.Transparent;
            this.ucLogout1.Location = new System.Drawing.Point(12, 47);
            this.ucLogout1.Name = "ucLogout1";
            this.ucLogout1.Size = new System.Drawing.Size(178, 54);
            this.ucLogout1.TabIndex = 11;
            // 
            // btnGenerarXML
            // 
            this.btnGenerarXML.Animated = true;
            this.btnGenerarXML.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarXML.BorderRadius = 8;
            this.btnGenerarXML.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarXML.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarXML.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarXML.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarXML.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarXML.FillColor = System.Drawing.Color.Purple;
            this.btnGenerarXML.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGenerarXML.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGenerarXML.ForeColor = System.Drawing.Color.White;
            this.btnGenerarXML.Location = new System.Drawing.Point(850, 601);
            this.btnGenerarXML.Name = "btnGenerarXML";
            this.btnGenerarXML.Size = new System.Drawing.Size(176, 45);
            this.btnGenerarXML.TabIndex = 12;
            this.btnGenerarXML.Text = "Generar XML";
            this.btnGenerarXML.Click += new System.EventHandler(this.btnGenerarXML_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProyectoLugComics.Properties.Resources._6885ab56_64a5_45b9_ad1d_86fd70f543c1;
            this.ClientSize = new System.Drawing.Size(1038, 649);
            this.Controls.Add(this.btnGenerarXML);
            this.Controls.Add(this.ucLogout1);
            this.Controls.Add(this.ucHome_1);
            this.Controls.Add(this.gridUltimosMovimientos);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.BtnComprarComics);
            this.Controls.Add(this.btnMostrarComics);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.guna2CircleButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUltimosMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCloseLogin;
        private Guna.UI2.WinForms.Guna2Button btnMostrarComics;
        private Guna.UI2.WinForms.Guna2Button BtnComprarComics;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView gridUltimosMovimientos;
        private UserControls.ucHome ucHome_1;
        private UserControls.ucLogout ucLogout1;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerarXML;
    }
}