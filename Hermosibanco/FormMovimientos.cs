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
    public partial class FormMovimientos : Form
    {
        BasedeDatos bd = new BasedeDatos();

        private void cargarDatos()
        {
            try
            {
                string campos = "", tablas= "", where = "";
                campos = "mov.id AS id_movimiento, mov.cantidad AS cantidad, mov.concepto AS concepto, cb.cuenta AS cuenta, CONCAT(ue.nombre, ' ', ue.apellido_paterno, ' ', ue.apellido_materno) AS nombre_emisor, CONCAT(ur.nombre, ' ', ur.apellido_paterno, ' ', ur.apellido_materno) AS nombre_receptor, ue.id AS id_emisor, ur.id AS id_receptor, mov.fecha AS fecha_movimiento, mov.tipo AS tipo";
                tablas = "movimientos AS mov INNER JOIN usuarios as ue ON mov.emisor_id = ue.id INNER JOIN usuarios AS ur ON mov.receptor_id = ur.id INNER JOIN cuentas_bancarias AS cb ON mov.cuenta_bancaria_id = cb.id";
                where += "mov.emisor_id = " + Properties.Settings.Default.idUsuario + " OR mov.receptor_id = " + Properties.Settings.Default.idUsuario + " ";
                if (rbFecha.Checked)
                    where += "AND fecha BETWEEN '" + dtFechaInicio.Value.ToString("yyyy-MM-dd") + "' AND '" + dtFechaFin.Value.ToString("yyyy-MM-dd") + "' ";
                else if (rbMes.Checked)
                {
                    DateTime mesInicio = new DateTime(dtMes.Value.Year, dtMes.Value.Month, 1, 0, 0, 0);
                    DateTime mesFin = mesInicio.AddMonths(1).AddSeconds(-1);
                    where += "AND fecha BETWEEN '" + mesInicio.ToString("yyyy-MM-dd") + "' AND '" + mesFin.ToString("yyyy-MM-dd") + "' ";
                }
                else
                {
                    DateTime anioInicio = new DateTime(dtAnio.Value.Year, 1, 1, 0, 0, 0);
                    DateTime anioFin = anioInicio.AddYears(1).AddSeconds(-1);
                    where += "AND fecha  BETWEEN '" + anioInicio.ToString("yyyy-MM-dd") + "' AND '" + anioFin.ToString("yyyy-MM-dd") + "' ";
                }
                /*
                    Tipos:{
                        0:TODOS
                        1:DEPOSITO
                        2:TRANSFERENCIA
                        3:RETIRO
                    }                
                */
                switch (cbbTipo.SelectedIndex)
                {
                    case 1:
                    case 2:
                    case 3:
                        where += " AND tipo = '" + cbbTipo.GetItemText(cbbTipo.SelectedItem) + "'";
                        break;
                }
                //MessageBox.Show("SELECT " + campos + "\nFROM " + tablas + "\nWHERE " + where);
                //MessageBox.Show("SELECT " + campos + "\nFROM " + tablas + "\nWHERE " + where);
                DataSet ds = bd.consult(campos, tablas, where, "SI");
                dgvData.DataSource = ds.Tables[0];
                cargarHeaders();
            }
            catch(Exception ex)
            {

            }
        }

        private void cargarHeaders()
        {
            dgvData.Columns[0].HeaderText = "ID";
            dgvData.Columns[1].HeaderText = "CANTIDAD";
            dgvData.Columns[2].HeaderText = "CONCEPTO";
            dgvData.Columns[3].HeaderText = "CUENTA";
            dgvData.Columns[4].HeaderText = "NOMBRE EMISOR";
            dgvData.Columns[5].HeaderText = "NOMBRE RECEPTOR";
            dgvData.Columns[6].HeaderText = "ID EMISOR";
            dgvData.Columns[7].HeaderText = "ID RECEPTOR";
            dgvData.Columns[8].HeaderText = "FECHA";
            dgvData.Columns[9].HeaderText = "TIPO";
            dgvData.Columns[0].Width = 25;
            dgvData.Columns[1].Width = 100;
            dgvData.Columns[2].Width = 250;
            dgvData.Columns[3].Width = 100;
            dgvData.Columns[4].Width = 250;
            dgvData.Columns[5].Width = 250;
            dgvData.Columns[6].Visible = false;
            dgvData.Columns[7].Visible = false;
            dgvData.Columns[8].Width = 100;
            dgvData.Columns[9].Width = 80;
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
        }

        public FormMovimientos()
        {
            InitializeComponent();
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cbbTipo.SelectedIndex = 0;
            rbFecha.Checked = true;
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
