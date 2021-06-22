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
    public partial class FormHistorialCompras : Form
    {
        BasedeDatos bd = new BasedeDatos();
        public FormHistorialCompras()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            try
            {
                string campos = "", tablas = "", where = "";
                campos = "comp.id,  CONCAT(ue.nombre, ' ', ue.apellido_paterno, ' ', ue.apellido_materno) AS Comprador, comp.importe, comp.status, comp.fecha";
                tablas = "compras AS comp INNER JOIN usuarios as ue ON comp.id_usuario = ue.id";
                where += "(comp.id_usuario = " + Properties.Settings.Default.idUsuario + ") ";
                if (rbFecha.Checked)
                    where += "AND fecha BETWEEN '" + dtFechaInicio.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + dtFechaFin.Value.ToString("yyyy-MM-dd") + " 23:59:59' ";
                else if (rbMes.Checked)
                {
                    DateTime mesInicio = new DateTime(dtMes.Value.Year, dtMes.Value.Month, 1, 0, 0, 0);
                    DateTime mesFin = mesInicio.AddMonths(1).AddSeconds(-1);
                    where += "AND fecha BETWEEN '" + mesInicio.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + mesFin.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                }
                else
                {
                    DateTime anioInicio = new DateTime(dtAnio.Value.Year, 1, 1, 0, 0, 0);
                    DateTime anioFin = anioInicio.AddYears(1).AddSeconds(-1);
                    where += "AND fecha  BETWEEN '" + anioInicio.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + anioFin.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                }

                if(cbbTipo.SelectedIndex == 1 || cbbTipo.SelectedIndex == 2)
                 where += " AND comp.status = '" + cbbTipo.GetItemText(cbbTipo.SelectedItem) + "'";

                DataSet ds = bd.consult(campos, tablas, where, "SI");
                dgvData.DataSource = ds.Tables[0];
                cargarHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarHeaders()
        {
            dgvData.Columns[0].HeaderText = "ID";
            dgvData.Columns[1].HeaderText = "COMPRA POR";
            dgvData.Columns[2].HeaderText = "IMPORTE";
            dgvData.Columns[3].HeaderText = "ESTATUS";
            dgvData.Columns[4].HeaderText = "FECHA Y HORA DE COMPRA";


        }

        private void FormHistorialCompras_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cbbTipo.SelectedIndex = 0;
            rbFecha.Checked = true;
            DateTime finDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            dtFechaInicio.MaxDate = finDia;
            dtFechaFin.MaxDate = finDia;
            dtMes.MaxDate = finDia;
            dtAnio.MaxDate = finDia;
            dtFechaFin.Value = DateTime.Now;
            dtFechaInicio.Value = finDia.AddMonths(-1).AddHours(-23).AddMinutes(-59).AddSeconds(-59);
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                if (Application.OpenForms["FormDetallesTransacciones"] != null)
                    Application.OpenForms["FormDetallesTransacciones"].Close();

                dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                if (Application.OpenForms["FormDetallesTransacciones"] == null)
                {
                    string id_compra = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dgvData.Rows[e.RowIndex].Selected = true;
                    FormDetallesTransacciones detalles = new FormDetallesTransacciones(int.Parse(id_compra));
                    detalles.Show();
                    detalles.FormClosed += Detalles_FormClosed;
                }
                else
                    MessageBox.Show("Se necesita cerrar la ventana de modificacion para poder abrir otra.");
            }
        }

        private void Detalles_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
        }
    }
}
