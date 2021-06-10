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
        private string usuario_id;

        public void setUsuarioId(string value)
        {
            usuario_id = value;
        }

        public string getUsuarioId()
        {
            return usuario_id;
        }

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

        private void cargarUsuario()
        {
            DataSet ds = bd.consult("nombre, apellido_paterno, apellido_materno, calle, num_exterior, num_interior, codigo_postal, municipio, estado, fecha_nacimiento, fecha_registro, puesto, usuario, password, cuenta", "usuarios INNER JOIN cuentas_bancarias ON usuarios.id = cuentas_bancarias.usuario_id", "usuarios.id = " + usuario_id, "SI");
            if(ds.Tables[0].Rows.Count > 0)
            {
                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[0]["apellido_materno"].ToString()))
                    txtApellidoMaterno.ForeColor = Color.Black;
                txtApellidoMaterno.Text = ds.Tables[0].Rows[0]["apellido_materno"].ToString();
                txtApellidoPaterno.Text = ds.Tables[0].Rows[0]["apellido_paterno"].ToString();
                txtCalle.Text = ds.Tables[0].Rows[0]["calle"].ToString();
                txtCP.Text = ds.Tables[0].Rows[0]["codigo_postal"].ToString();
                txtCuenta.Text = ds.Tables[0].Rows[0]["cuenta"].ToString();
                txtNoExt.Text = ds.Tables[0].Rows[0]["num_exterior"].ToString();
                if (!String.IsNullOrEmpty(ds.Tables[0].Rows[0]["num_interior"].ToString()))
                    txtNoInt.ForeColor = Color.Black;
                txtNoInt.Text = ds.Tables[0].Rows[0]["num_interior"].ToString();
                txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtPassword.Text = ds.Tables[0].Rows[0]["password"].ToString();
                txtPuesto.Text = ds.Tables[0].Rows[0]["puesto"].ToString();
                txtUsuario.Text = ds.Tables[0].Rows[0]["usuario"].ToString();
                dtFechaNacimiento.Value = DateTime.Parse(ds.Tables[0].Rows[0]["fecha_nacimiento"].ToString());
                dtFechaNacimiento.MaxDate = DateTime.Parse(ds.Tables[0].Rows[0]["fecha_nacimiento"].ToString());
                dtFechaNacimiento.MinDate = DateTime.Parse(ds.Tables[0].Rows[0]["fecha_nacimiento"].ToString());
                DataSet ds_aux = bd.consult("id", "estados", "estado = '" + ds.Tables[0].Rows[0]["estado"].ToString() + "'", "SI");
                cbbEstado.SelectedValue = ds_aux.Tables[0].Rows[0]["id"].ToString();
                ds_aux = null;
                ds_aux = bd.consult("id", "municipios", "municipio = '" + ds.Tables[0].Rows[0]["municipio"].ToString() + "'", "SI");
                cbbMunicipio.SelectedValue = ds_aux.Tables[0].Rows[0]["id"].ToString();                
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

        public void deshabilitarTextBox()
        {
            txtCuenta.ReadOnly = true;
            txtApellidoPaterno.ReadOnly = true;
            txtApellidoMaterno.ReadOnly = true;
            txtCalle.ReadOnly = true;
            txtCP.ReadOnly = true;
            txtCuenta.ReadOnly = true;
            txtNoExt.ReadOnly = true;
            txtNoInt.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtUsuario.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPuesto.ReadOnly = true;
            btnGuardar.Visible = false;
            //dtFechaNacimiento.Enabled = false;
            cbbEstado.Enabled = false;
            cbbMunicipio.Enabled = false;
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
            if(string.IsNullOrEmpty(usuario_id))
            {
                string cuenta = "";
                do
                {
                    cuenta = crearCuenta();
                } while (validarExisteCuenta(cuenta));
                txtCuenta.Text = cuenta;
            }
            else
            {
                try
                {
                    cargarUsuario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en método cargarUsuario()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                       
            showPassword = 0;            
            txtCuenta.ReadOnly = true;
            txtNoInt_Leave(sender, e);
            txtApellidoMaterno_Leave(sender, e);

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
                        string apellidoMaterno = "", noInt = "";
                        if(txtApellidoMaterno.Text != "OPCIONAL" && txtApellidoMaterno.Text != "")
                            apellidoMaterno = txtApellidoMaterno.Text;
                        if (txtNoInt.Text != "OPCIONAL" && txtNoInt.Text != "")
                            noInt = txtNoInt.Text;
                        string campos = "nombre, apellido_paterno, apellido_materno, calle, num_exterior, num_interior, codigo_postal, municipio, estado, fecha_nacimiento, fecha_registro, status, puesto, usuario, password";
                        
                        string values = "'" + txtNombre.Text + "', " + "'" + txtApellidoPaterno.Text + "', " + "'" + apellidoMaterno + "', " + "'" + txtCalle.Text + "', " + "'" + txtNoExt.Text + "', " + "'" + noInt + "', " + "'" + txtCP.Text + "', " + "'" + cbbMunicipio.GetItemText(cbbMunicipio.SelectedItem).ToUpper() + "', " + "'" + cbbEstado.GetItemText(cbbEstado.SelectedItem).ToUpper() + "', " + "'" + dtFechaNacimiento.Value.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 'ACTIVO', '" + txtPuesto.Text + "', '" + txtUsuario.Text + "', '" + txtPassword.Text + "'";
                        if (String.IsNullOrEmpty(usuario_id))
                        {
                            bd.insert("usuarios", campos, values);
                            bd.insert("cuentas_bancarias", "cuenta, usuario_id, saldo", "'" + txtCuenta.Text + "', " + bd.lastRecord("id", "ultimo_id", "usuarios").ToString() + ", 0.00");
                        }
                        else
                        {
                            bd.update("nombre = '" + txtNombre.Text + "', apellido_paterno = '" + txtApellidoPaterno.Text + "', apellido_materno = '" + apellidoMaterno + "', calle = '" + txtCalle.Text + "', num_exterior = '" + txtNoExt.Text + "', num_interior = '" + noInt +"', codigo_postal = '" + txtCP.Text + "', municipio = '" + cbbMunicipio.GetItemText(cbbMunicipio.SelectedItem).ToUpper() + "', estado = '" + cbbEstado.GetItemText(cbbEstado.SelectedItem).ToUpper() + "', fecha_nacimiento = '" + dtFechaNacimiento.Value.ToString("yyyy-MM-dd") + "', puesto = '" + txtPuesto.Text + "', usuario = '" + txtUsuario.Text + "', password = '" + txtPassword.Text +"'", "usuarios", "id = " + usuario_id, "SI");
                        }
                        
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

        private void txtNoInt_Enter(object sender, EventArgs e)
        {
            if (txtNoInt.Text == "OPCIONAL")
            {
                txtNoInt.ForeColor = Color.Black;
                txtNoInt.Text = "";
            }
        }

        private void txtNoInt_Leave(object sender, EventArgs e)
        {
            if (txtNoInt.Text == String.Empty)
            {
                txtNoInt.ForeColor = Color.DimGray;
                txtNoInt.Text = "OPCIONAL";
            }
        }


    }
}
