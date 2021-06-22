using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hermosibanco
{
    public partial class FormDetallesTransacciones : Form
    {
        BasedeDatos bd = new BasedeDatos();
        int id_compra = 0;
        public FormDetallesTransacciones(int id_compra)
        {
            InitializeComponent();
            this.id_compra = id_compra;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void cargarDatos()
        {
            try
            {
                string campos = "", tablas = "", where = "";
                campos = "art.descripcion, hist.cantidad, ar.precio, (hist.cantidad * ar.precio) as Total";
                tablas = "historial_articulos_compras AS hist INNER JOIN articulos as art ON hist.articulo_id = art.id INNER JOIN articulos as ar ON hist.articulo_id = ar.id";
                where += "(hist.compra_id = " + id_compra + ") ";

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
            dgvData.Columns[0].HeaderText = "DESCRIPCIÓN";
            dgvData.Columns[1].HeaderText = "CANTIDAD";
            dgvData.Columns[2].HeaderText = "PRECIO UNITARIO";
            dgvData.Columns[3].HeaderText = "TOTAL";
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Orange;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = this.BackColor;
        }

        private void FormDetallesTransacciones_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void pbClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetallesTransacciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
