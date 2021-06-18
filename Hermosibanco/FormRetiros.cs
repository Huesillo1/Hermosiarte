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
    public partial class FormRetiros : Form
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
            string where = "usuario_solicita_id = " + Properties.Settings.Default.idUsuario;
            if (rbFecha.Checked)
                where += " AND mov.fecha BETWEEN '" + dtFechaInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtFechaFin.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";
            else if (rbMes.Checked)
            {
                DateTime mesInicio = new DateTime(dtMes.Value.Year, dtMes.Value.Month, 1, 0, 0, 0);
                DateTime mesFin = mesInicio.AddMonths(1).AddSeconds(-1);
                where += " AND mov.fecha BETWEEN '" + mesInicio.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + mesFin.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            }
            else if (rbAnio.Checked)
            {
                DateTime anioInicio = new DateTime(dtAnio.Value.Year, 1, 1, 0, 0, 0);
                DateTime anioFin = anioInicio.AddYears(1).AddSeconds(-1);
                where += " AND mov.fecha  BETWEEN '" + anioInicio.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + anioFin.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
            }            
            switch (cbbStatus.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                    if (!string.IsNullOrEmpty(where))
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
            dgvData.Columns[10].HeaderText = "FECHA AUTORIZA/RECHAZA";
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

        public FormRetiros()
        {
            InitializeComponent();
        }

        private void FormRetiros_Load(object sender, EventArgs e)
        {
            cargarDatos();
            rbMes.Checked = true;
            cbbStatus.SelectedIndex = 0;
            DateTime finDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            dtFechaInicio.MaxDate = finDia;
            dtFechaFin.MaxDate = finDia;
            dtMes.MaxDate = finDia;
            dtAnio.MaxDate = finDia;
            dtFechaFin.Value = DateTime.Now;
            dtFechaInicio.Value = finDia.AddMonths(-1).AddHours(-23).AddMinutes(-59).AddSeconds(-59);
        }

        private void btnSolicitarRetiro_Click(object sender, EventArgs e)
        {
            FormDetallesSolicitudRetiro formDetallesSolicitudRetiro = new FormDetallesSolicitudRetiro();
            formDetallesSolicitudRetiro.ShowDialog();
            cargarDatos();
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
