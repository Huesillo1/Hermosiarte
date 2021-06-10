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
            DataSet ds = bd.consult("*", "retiros", "usuario_solicita_id = " + Properties.Settings.Default.idUsuario, "SI");
            if (ds.Tables[0].Rows.Count > 0)
                dgvData.DataSource = ds.Tables[0];
        }

        public FormRetiros()
        {
            InitializeComponent();
        }

        private void FormRetiros_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnSolicitarRetiro_Click(object sender, EventArgs e)
        {
            FormDetallesSolicitudRetiro formDetallesSolicitudRetiro = new FormDetallesSolicitudRetiro();
            formDetallesSolicitudRetiro.ShowDialog();
            cargarDatos();
        }
    }
}
