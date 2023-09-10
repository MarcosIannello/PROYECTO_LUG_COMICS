using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectionStringEjemplo
{
    public partial class frmFacultad : Form
    {
        public frmFacultad()
        {
            InitializeComponent();
        }

        SqlConnection cn;

        public void Conectar()
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=MARCOS-ASUS;Initial Catalog=FACULTAD;Integrated Security=True";
            //EN EL TEORICO TOMA QUE ES CADA COSA DEL CONNECTION STRING
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDataTable();
        }

        private void CargarDataTable()
        {
            gridALumnos.DataSource = null;

            Conectar();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from ALUMNOS";

            DataTable TodosLosAlumnos = new DataTable();

            TodosLosAlumnos.Load(cmd.ExecuteReader());

            gridALumnos.DataSource = TodosLosAlumnos;

            Desconectar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conectar();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into ALUMNOS(idAlumno,Nombre,Edad) values("+int.Parse(txtIdAlumno.Text)+",'"+txtNombre.Text+"',"+ int.Parse(txtEdad.Text)+")";

            cmd.ExecuteNonQuery();

            Desconectar();

            MessageBox.Show("SE AGREGO CORRECTAMENTE EL NUEVO REGISTRO");

            clearControls();
            CargarDataTable();
            ResetearForm();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Desconectar();
        }

        public void clearControls()
        {
            txtEdad.Clear();
            txtIdAlumno.Clear();
            txtNombre.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conectar();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE ALUMNOS SET Nombre = @Nombre, Edad = @Edad WHERE idAlumno = @idAlumno";

            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Edad", int.Parse(txtEdad.Text));
            cmd.Parameters.AddWithValue("@idAlumno", int.Parse(txtIdAlumno.Text));

            cmd.ExecuteNonQuery();

            Desconectar();

            MessageBox.Show("Se modifico correctamente el alumno");
            clearControls();
            CargarDataTable();
            ResetearForm();

        }


        private void gridALumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridALumnos.Rows[e.RowIndex];

            string nombre = row.Cells["Nombre"].Value.ToString();
            int edad = Convert.ToInt32(row.Cells["Edad"].Value);
            int idAlumno = Convert.ToInt32(row.Cells["idAlumno"].Value);

            txtNombre.Text = nombre;
            txtIdAlumno.Text = idAlumno.ToString();
            txtEdad.Text = edad.ToString();

            txtIdAlumno.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetearForm();
        }

        private void ResetearForm()
        {
            clearControls();
            txtIdAlumno.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conectar();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Alumnos where idAlumno = @idAlumno";

            cmd.Parameters.AddWithValue("@idAlumno", int.Parse(txtIdAlumno.Text));

            cmd.ExecuteNonQuery();

            Desconectar();
            MessageBox.Show("Se Elimino correctamente el alumno");
            clearControls();
            CargarDataTable();
            ResetearForm();
        }
    }
}
