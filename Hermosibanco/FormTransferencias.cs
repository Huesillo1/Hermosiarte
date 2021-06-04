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
    public partial class FormTransferencias : Form
    {
        BasedeDatos bd = new BasedeDatos();

        private void cargarContactosComboBox()
        {
            DataSet ds = bd.consult("*", "cuentas_bancarias", "usuario_id = " + Properties.Settings.Default.idUsuario, "SI");
            if(ds.Tables[0].Rows.Count > 0)
            {
                cbbCuentaEmisora.DisplayMember = "cuenta";
                cbbCuentaEmisora.ValueMember = "id";
                cbbCuentaEmisora.DataSource = ds.Tables[0];
            }
        }

        private void cargarHeaders()
        {
            dgvData.Columns[0].HeaderText = "CUENTA";
            dgvData.Columns[1].HeaderText = "NOMBRE";
            dgvData.Columns[0].Width = 100;
            dgvData.Columns[1].Width = 608;
            dgvData.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void cargarDatosTabla()
        {
            DataSet ds = bd.consult("cb.cuenta AS cuenta_banco, CONCAT(u.nombre,' ',u.apellido_paterno,' ', u.apellido_materno) AS nombre_completo", "contactos AS c INNER JOIN usuarios AS u ON c.usuario_destinatario_id = u.id INNER JOIN cuentas_bancarias AS cb ON cb.id = c.cuenta_bancaria_destinatario_id ", "c.usuario_remitente_id = " + Properties.Settings.Default.idUsuario, "SI");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvData.DataSource = ds.Tables[0];
                cargarHeaders();
            }
        }


        public FormTransferencias()
        {
            InitializeComponent();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTransferencias_Load(object sender, EventArgs e)
        {
            //dgvData.AutoGenerateColumns = true;
            cargarContactosComboBox();
            cargarDatosTabla();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            DataSet ds = bd.consult("id, cuenta, usuario_id","cuentas_bancarias","cuenta = '" + txtCuentaReceptora.Text + "'","SI");
            if(ds.Tables[0].Rows.Count > 0)
            {
                DataSet ds_aux = bd.consult("id", "contactos", "usuario_remitente_id = " + Properties.Settings.Default.idUsuario + " and usuario_destinatario_id =" + ds.Tables[0].Rows[0]["usuario_id"].ToString() + " and cuenta_bancaria_destinatario_id = " + ds.Tables[0].Rows[0]["id"].ToString(), "SI");
                if(ds_aux.Tables[0].Rows.Count > 0)                
                    MessageBox.Show("El usuario con la cuenta " + txtCuentaReceptora.Text + ".\nYa se encuentra actualmente en tus contactos.", "Contacto Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ds_aux = null;
                    ds_aux = bd.consult("u.id, CONCAT(u.nombre,' ', u.apellido_paterno,' ', u.apellido_materno) AS nombre_completo", "usuarios AS u", "u.id = " + ds.Tables[0].Rows[0]["usuario_id"], "SI");
                    if(ds_aux.Tables[0].Rows.Count > 0)
                    {
                        if(MessageBox.Show("¿Deseas agregar a " + ds_aux.Tables[0].Rows[0]["nombre_completo"].ToString() + " a tus contactos?\nCuenta: " + txtCuentaReceptora.Text,"Agregar Contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                bd.insert("contactos", "usuario_remitente_id, usuario_destinatario_id, cuenta_bancaria_destinatario_id", Properties.Settings.Default.idUsuario + ", " + ds.Tables[0].Rows[0]["usuario_id"].ToString() + ", " + ds.Tables[0].Rows[0]["usuario_id"].ToString());
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Algo salió mal.\n" + ex.Message);
                            }                                
                        }
                    }                    
                }
            }
            cargarDatosTabla();
        }

        private void agregarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transferirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransferir formTransferir = new FormTransferir();
            formTransferir.setCuenta(dgvData.CurrentRow.Cells[0].Value.ToString());
            formTransferir.setNombre(dgvData.CurrentRow.Cells[1].Value.ToString());
            formTransferir.ShowDialog();
        }
    }
}
