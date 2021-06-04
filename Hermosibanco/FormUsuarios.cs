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
    public partial class FormUsuarios : Form
    {
        BasedeDatos bd = new BasedeDatos();
        private void cargarHeaders()
        {
            dgvData.Columns[0].HeaderText = "NOMBRE COMPLETO";
            dgvData.Columns[1].HeaderText = "CUENTA";
            dgvData.Columns[2].HeaderText = "USUARIO";
            dgvData.Columns[3].HeaderText = "FECHA DE NACIMIENTO";
            dgvData.Columns[4].HeaderText = "ESTADO";
            dgvData.Columns[5].HeaderText = "MUNICIPIO";
            dgvData.Columns[6].HeaderText = "CALLE";
            dgvData.Columns[7].HeaderText = "NO. INT.";
            dgvData.Columns[8].HeaderText = "NO. EXT.";
            dgvData.Columns[9].HeaderText = "C.P.";
            dgvData.Columns[10].HeaderText = "PUESTO";
            dgvData.Columns[11].HeaderText = "FECHA DE REGISTRO";
            dgvData.Columns[12].HeaderText = "ESTATUS";
            dgvData.Columns[0].Width = 240;
            dgvData.Columns[1].Width = 90;
            dgvData.Columns[2].Width = 120;
            dgvData.Columns[3].Width = 80;
            dgvData.Columns[4].Width = 120;
            dgvData.Columns[5].Width = 140;
            dgvData.Columns[6].Width = 240;
            dgvData.Columns[7].Width = 70;
            dgvData.Columns[8].Width = 70;
            dgvData.Columns[9].Width = 60;
            dgvData.Columns[10].Width = 200;
            dgvData.Columns[11].Width = 80;
            dgvData.Columns[12].Width = 80;
            dgvData.Columns[13].Visible = false;
            dgvData.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void cargarDatos()
        {
            string where = "";

            if (txtNombre.Text != String.Empty)
            {
                string like = "nombre LIKE '%" + txtNombre.Text + "%' OR apellido_paterno LIKE '%" + txtNombre.Text + "%' OR apellido_materno LIKE '%" + txtNombre.Text + "%'";
                if (cbbStatus.SelectedIndex == 0)
                    where += like;
                else if (cbbStatus.SelectedIndex == 1)
                    where += "status = 'ACTIVO' AND " + like;                
                else
                    where += "status = 'INACTIVO' AND " + like;
            }else if(txtCuenta.Text != String.Empty)
            {
                if (cbbStatus.SelectedIndex == 1)
                    where += "cuenta = '" + txtCuenta.Text + "' AND status = 'ACTIVO'";
                else if(cbbStatus.SelectedIndex == 2)
                    where += "cuenta = '" + txtCuenta.Text + "' AND status = 'INACTIVO'";
                else
                    where += "cuenta = '" + txtCuenta.Text + "' ";
            }
            else
            {
                if (cbbStatus.SelectedIndex == 1)
                    where += "status = 'ACTIVO'";
                else if (cbbStatus.SelectedIndex == 2)
                    where += "status = 'INACTIVO'";
            }
            
            string campos = "CONCAT(nombre, ' ', apellido_paterno, ' ', apellido_materno) AS nombre_completo, cuenta, usuario, fecha_nacimiento, ";
            campos += "estado, municipio, calle, num_exterior, num_interior, codigo_postal, puesto, fecha_registro, status, usuarios.id";
            DataSet ds;
            if (where == "")
                ds = bd.consult(campos, "usuarios INNER JOIN cuentas_bancarias ON usuarios.id = cuentas_bancarias.usuario_id", "", "NO");
            else
                ds = bd.consult(campos, "usuarios INNER JOIN cuentas_bancarias ON usuarios.id = cuentas_bancarias.usuario_id", where, "SI");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvData.DataSource = ds.Tables[0];
                cargarHeaders();
            }
            else
            {
                dgvData.DataSource = null;
                //dgvData.Rows.Clear();
                //cargarHeaders();
            }
        }



        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario formAgregarUsuario = new FormAgregarUsuario();
            formAgregarUsuario.ShowDialog();
            cargarDatos();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cbbStatus.SelectedIndex = 0;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtCuenta.Text = "";
            cargarDatos();
        }

        private void txtCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                cargarDatos();
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbStatus.SelectedIndex.ToString());
            cargarDatos();
        }

        private void depositarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeposito formDeposito = new FormDeposito();
            formDeposito.setCuenta(dgvData.CurrentRow.Cells[1].Value.ToString());
            formDeposito.setIdUsuario(dgvData.CurrentRow.Cells[13].Value.ToString());
            formDeposito.setNombre(dgvData.CurrentRow.Cells[0].Value.ToString());
            formDeposito.ShowDialog();
            cargarDatos();
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(dgvData.CurrentRow.Cells[13].Value.ToString()))
                bd.update("status = 'INACTIVO'", "usuarios", "id = " + dgvData.CurrentRow.Cells[13].Value, "SI");
            cargarDatos();
        }
    }
}
