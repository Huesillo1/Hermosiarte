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
    public partial class FormAutorizarRetiro : Form
    {
        BasedeDatos bd = new BasedeDatos();

        private void cargarDatos()
        {
            string campos = "r.id AS id_retiro, mov.concepto AS concepto_retiro, mov.cantidad AS cantidad_retiro, cb.cuenta AS cuenta_bancaria, clave, " + 
                            "CONCAT(us.nombre, ' ', us.apellido_paterno, ' ', us.apellido_materno ) AS nombre_completo_usuario_solicita, " + 
                            "CONCAT(ua.nombre, ' ', ua.apellido_paterno, ' ', ua.apellido_materno ) AS nombre_completo_usuario_autoriza, " +
                            "r.status AS status_retiro, r.observaciones AS observaciones_retiro, mov.fecha as fecha_movimiento, r.fecha_autoriza AS fecha_autoriza_retiro, " + 
                            "us.id, ua.id, mov.id ";

            string tablas = "retiros AS r INNER JOIN movimientos AS mov ON r.movimiento_id = mov.id " + 
                            "INNER JOIN cuentas_bancarias AS cb ON mov.cuenta_bancaria_id = cb.id " + 
                            "INNER JOIN usuarios AS us ON r.usuario_solicita_id = us.id " + 
                            "LEFT JOIN usuarios AS ua ON r.usuario_autoriza_id = ua.id";
            string where = "";
            if(rbFecha.Checked)
                where += "mov.fecha BETWEEN '" + dtFechaInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtFechaFin.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";
            else if (rbMes.Checked)
            {
                DateTime mesInicio = new DateTime(dtMes.Value.Year, dtMes.Value.Month, 1, 0, 0, 0);
                DateTime mesFin = mesInicio.AddMonths(1).AddSeconds(-1);
                where += "mov.fecha BETWEEN '" + mesInicio.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + mesFin.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            }else if (rbAnio.Checked)
            {
                DateTime anioInicio = new DateTime(dtAnio.Value.Year, 1, 1, 0, 0, 0);
                DateTime anioFin = anioInicio.AddYears(1).AddSeconds(-1);
                where += "mov.fecha  BETWEEN '" + anioInicio.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + anioFin.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            }
            if (!string.IsNullOrEmpty(getClave()) && !string.IsNullOrWhiteSpace(getClave()))
            {
                if (!string.IsNullOrEmpty(where))
                    where += " AND r.clave LIKE '" + getClave().Trim() + "%'";
                else
                    where += "r.clave LIKE '" + getClave().Trim() + "%'";
            }            
            switch (cbbStatus.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                    if(!string.IsNullOrEmpty(where))
                        where += " AND r.status = '" + cbbStatus.GetItemText(cbbStatus.SelectedItem) + "' ";
                    else
                        where += "r.status = '" + cbbStatus.GetItemText(cbbStatus.SelectedItem) + "' ";
                    break;
            }
            //MessageBox.Show(where);
            DataSet ds;
            if (string.IsNullOrEmpty(where))
                ds = bd.consult(campos, tablas, "", "NO");
            else
                ds = bd.consult(campos, tablas, where, "SI");
            dgvData.DataSource = ds.Tables[0];
            cargarHeaders();
        }

        private void cargarHeaders()
        {
            dgvData.Columns[0].HeaderText = "ID";
            dgvData.Columns[1].HeaderText = "CONCEPTO";
            dgvData.Columns[2].HeaderText = "CANTIDAD";
            dgvData.Columns[3].HeaderText = "CUENTA BANCARIA";
            dgvData.Columns[4].HeaderText = "CLAVE DE RETIRO";
            dgvData.Columns[5].HeaderText = "USUARIO SOLICITA";
            dgvData.Columns[6].HeaderText = "USUARIO AUTORIZA";
            dgvData.Columns[7].HeaderText = "ESTATUS";
            dgvData.Columns[8].HeaderText = "OBSERVACIONES";
            dgvData.Columns[9].HeaderText = "FECHA";
            dgvData.Columns[10].HeaderText = "FECHA AUTORIZA";
            dgvData.Columns[11].HeaderText = "ID USUARIO SOLICITA";
            dgvData.Columns[12].HeaderText = "ID USUARIO AUTORIZA";
            dgvData.Columns[13].HeaderText = "ID MOVIMIENTO";
            dgvData.Columns[0].Visible = false;
            dgvData.Columns[1].Width = 200;
            dgvData.Columns[2].Width = 100;
            dgvData.Columns[3].Width = 100;
            dgvData.Columns[4].Width = 170;
            dgvData.Columns[5].Width = 200;
            dgvData.Columns[6].Width = 200;
            dgvData.Columns[7].Width = 100;
            dgvData.Columns[8].Width = 200;
            dgvData.Columns[9].Width = 135;
            dgvData.Columns[10].Width = 135;
            dgvData.Columns[11].Visible = false;
            dgvData.Columns[12].Visible = false;
            dgvData.Columns[13].Visible = false;

            for (int i = 0; i < 11; i++)
                dgvData.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private bool saldoSuficiente()
        {
            if(dgvData.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dgvData.CurrentRow.Cells[3].Value.ToString()))
                {
                    DataSet ds = bd.consult("id, saldo", "cuentas_bancarias", "cuenta = '" + dgvData.CurrentRow.Cells[3].Value.ToString() + "'", "SI");
                    return double.Parse(ds.Tables[0].Rows[0]["saldo"].ToString()) >= double.Parse(dgvData.CurrentRow.Cells[2].Value.ToString());                    
                }                    
            }
            return false;
        }

        private double getSaldo()
        {
            if (dgvData.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dgvData.CurrentRow.Cells[3].Value.ToString()))
                {
                    DataSet ds = bd.consult("id, saldo", "cuentas_bancarias", "cuenta = '" + dgvData.CurrentRow.Cells[3].Value.ToString() + "'", "SI");
                    return double.Parse(ds.Tables[0].Rows[0]["saldo"].ToString());
                }
            }
            return 0.00;
        }

        private string getClave()
        {
            string[] clave = txtClave.Text.Split('-');
            string clave_retiro = "";
            for (int i = 0; i < clave.Length; i++)
                clave_retiro += clave[i];
            return clave_retiro;
        }

        public FormAutorizarRetiro()
        {
            InitializeComponent();
        }

        private void FormAutorizarRetiro_Load(object sender, EventArgs e)
        {
            cargarDatos();
            rbMes.Checked = true;
            cbbStatus.SelectedIndex = 2;
            DateTime finDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            dtFechaInicio.MaxDate = finDia;
            dtFechaFin.MaxDate = finDia;
            dtMes.MaxDate = finDia;
            dtAnio.MaxDate = finDia;
            dtFechaFin.Value = DateTime.Now;
            dtFechaInicio.Value = finDia.AddMonths(-1).AddHours(-23).AddMinutes(-59).AddSeconds(-59);
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void autorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saldoSuficiente())
            {
                try
                {
                    bd.update("saldo = " + (getSaldo() - double.Parse(dgvData.CurrentRow.Cells[2].Value.ToString())).ToString(), "cuentas_bancarias", "cuenta = '" + dgvData.CurrentRow.Cells[2].Value.ToString() + "'", "SI");
                }
                catch(MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message,"Error al actualizar saldo - " + ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    bd.update("status = 'APROBADO', fecha_autoriza = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd") + "', usuario_autoriza_id = " + Properties.Settings.Default.idUsuario, "retiros", "id = " + dgvData.CurrentRow.Cells[0].Value.ToString(), "SI");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error al actualizar status retiro - " + ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    bd.update("estatus = 'EXITOSO'", "movimientos", "id = " + dgvData.CurrentRow.Cells[13].Value.ToString(), "SI");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error al actualizar estatus movimiento - " + ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargarDatos();
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(getClave());
            cargarDatos();
        }
    }
}
