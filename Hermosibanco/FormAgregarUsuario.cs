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
    public partial class FormAgregarUsuario : Form
    {
        BasedeDatos bd = new BasedeDatos();
        private int showPassword;

        private void cargarEstados()
        {
            DataSet ds = bd.consult("*", "estados", "", "NO");
            if (ds.Tables[0].Rows.Count > 0)
            {
                cbbEstado.DisplayMember = "estado";
                cbbEstado.ValueMember = "id";
                cbbEstado.DataSource = ds.Tables[0];
            }
        }

        private void cargarMunicipios(string estado)
        {
            try
            {
                int i = Int32.Parse(estado);
                DataSet ds = bd.consult("m.id as value, m.municipio as municipio", "municipios as m INNER JOIN estados_municipios as e ON m.id = e.municipios_id", "e.estados_id = " + cbbEstado.SelectedValue.ToString() + " ORDER BY municipio", "SI");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cbbMunicipio.DisplayMember = "municipio";
                    cbbMunicipio.ValueMember = "value";
                    cbbMunicipio.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private bool fieldsEmpty()
        {
            if (txtNombre.Text == String.Empty || txtApellidoPaterno.Text == String.Empty || txtUsuario.Text == String.Empty || txtPassword.Text == String.Empty || txtCuenta.Text == String.Empty || txtCalle.Text == String.Empty || txtNoExt.Text == String.Empty || txtCP.Text == String.Empty)
            {
                return true;
            }
            return false;
        }

        private string crearCuenta()
        {
            Random numero = new Random();
            string cuenta = "";
            for (int i = 0; i < 10; i++)
                cuenta += numero.Next(0, 10).ToString();
            return cuenta;
        }

        private bool validarExisteCuenta(string cuenta)
        {
            DataSet ds = bd.consult("id", "cuentas_bancarias", "cuenta = '" + cuenta + "'", "SI");
            if (ds.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }

        public FormAgregarUsuario()
        {
            InitializeComponent();
        }

        private void FormAgregarUsuario_Load(object sender, EventArgs e)
        {
            cargarEstados();
            cbbEstado.SelectedIndex = 0;
            dtFechaNacimiento.MaxDate = DateTime.Now;
            string cuenta = "";
            do
            {
                cuenta = crearCuenta();

            } while (validarExisteCuenta(cuenta));
            txtCuenta.Text = cuenta;
            txtCuenta.ReadOnly = true;
            showPassword = 0;
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarMunicipios(cbbEstado.SelectedValue.ToString());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtFechaNacimiento.Text + " | " + dtFechaNacimiento.Value.ToString("yyyy-MM-dd") );
            if (fieldsEmpty())
                MessageBox.Show("Debe rellenar todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (txtCP.Text.Length < 5)
                    MessageBox.Show("El código postal debe ser de 5 dígitos", "Código Postal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (txtPassword.Text.Length < 8)
                        MessageBox.Show("La contraseña debe ser de 8 caracteres o más", "Código Postal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        string campos = "nombre, apellido_paterno, apellido_materno, calle, num_exterior, num_interior, codigo_postal, municipio, estado, fecha_nacimiento, fecha_registro, status, puesto, usuario, password";
                        string values = "'" + txtNombre.Text + "', " + "'" + txtApellidoPaterno.Text + "', " + "'" + txtApellidoMaterno.Text + "', " + "'" + txtCalle.Text + "', " + "'" + txtNoExt.Text + "', " + "'" + txtNoInt.Text + "', " + "'" + txtCP.Text + "', " + "'" + cbbMunicipio.GetItemText(cbbMunicipio.SelectedItem).ToUpper() + "', " + "'" + cbbEstado.GetItemText(cbbEstado.SelectedItem).ToUpper() + "', " + "'" + dtFechaNacimiento.Value.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 'ACTIVO', '" + txtPuesto.Text + "', '" + txtUsuario.Text + "', '" + txtPassword.Text + "'";

                        bd.insert("usuarios", campos, values);
                        bd.insert("cuentas_bancarias", "cuenta, usuario_id, saldo", "'" + txtCuenta.Text + "', " + bd.lastRecord("id", "ultimo_id", "usuarios").ToString() + ", 0.00");
                        this.Close();
                    }
                }
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (showPassword == 0)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowPassword.Image = Properties.Resources.icons8_key_16;
                showPassword += 1;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowPassword.Image = Properties.Resources.icons8_no_key_16;
                showPassword -= 1;
            }
        }

        private void txtApellidoMaterno_Enter(object sender, EventArgs e)
        {
            if (txtApellidoMaterno.Text == "OPCIONAL")
            {
                txtApellidoMaterno.ForeColor = Color.Black;
                txtApellidoMaterno.Text = "";

            }
        }

        private void txtApellidoMaterno_Leave(object sender, EventArgs e)
        {
            if(txtApellidoMaterno.Text == String.Empty)
            {
                txtApellidoMaterno.ForeColor = Color.DimGray;
                txtApellidoMaterno.Text = "OPCIONAL";
            }
        }
    }
}
