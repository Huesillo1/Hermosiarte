using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermosibanco
{
    public partial class FormMiCuenta : Form
    {
        BasedeDatos bd = new BasedeDatos();
        private int showPassword;

        public FormMiCuenta()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            //CONCAT(nombre,' ',apellido_paterno,' ', apellido_materno) as nombre_completo
            //
            string campos = "CONCAT(nombre,' ',apellido_paterno,' ', apellido_materno) as nombre_completo, calle, num_exterior, num_interior, codigo_postal, municipio, estado, fecha_nacimiento, fecha_registro, status, puesto, cuenta, saldo, usuario, password ";
            DataSet ds = new DataSet();
            try
            {
                ds = bd.consult(campos, "usuarios INNER JOIN cuentas_bancarias ON cuentas_bancarias.usuario_id = usuarios.id", " usuarios.id = " + Properties.Settings.Default.idUsuario, "SI");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtNombreCompleto.Text = ds.Tables[0].Rows[0]["nombre_completo"].ToString();
                    txtUsuario.Text = ds.Tables[0].Rows[0]["usuario"].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0]["password"].ToString();

                    txtFechaNacimiento.Text = DateTime.Parse(ds.Tables[0].Rows[0]["fecha_nacimiento"].ToString()).ToShortDateString();
                    txtFechaRegistro.Text = DateTime.Parse(ds.Tables[0].Rows[0]["fecha_registro"].ToString()).ToShortDateString();
                    txtStatus.Text = ds.Tables[0].Rows[0]["status"].ToString();
                    txtPuesto.Text = ds.Tables[0].Rows[0]["puesto"].ToString();
                    txtCuenta.Text = ds.Tables[0].Rows[0]["cuenta"].ToString();
                    txtCalle.Text = ds.Tables[0].Rows[0]["calle"].ToString();
                    txtNoExt.Text = ds.Tables[0].Rows[0]["num_exterior"].ToString();
                    txtNoInt.Text = ds.Tables[0].Rows[0]["num_interior"].ToString();
                    txtCP.Text = ds.Tables[0].Rows[0]["codigo_postal"].ToString();
                    txtMunicipio.Text = ds.Tables[0].Rows[0]["municipio"].ToString();
                    txtEstado.Text = ds.Tables[0].Rows[0]["estado"].ToString();
                    txtSaldo.Text = "$" + ds.Tables[0].Rows[0]["saldo"].ToString();
                }
                else
                    MessageBox.Show("No se pudieron recuperar los datos", "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "MySQL Exception");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }
        }

        private void FormMiCuenta_Load(object sender, EventArgs e)
        {
            showPassword = 0;
            cargarDatos();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (showPassword == 0)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowPassword.Image = Properties.Resources.icons8_key_16;
                showPassword = 1;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowPassword.Image = Properties.Resources.icons8_no_key_16;
                showPassword = 0;
            }
        }

    }
}
