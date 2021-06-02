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
            DataSet ds = bd.consult("CONCAT(u.nombre,' ',u.apellido_paterno,' ', u.apellido_materno) as nombre_completo, c.usuario_destinatario_id", "contactos AS c INNER JOIN usuarios AS u ON c.usuario_destinatario_id = u.id", "c.usuario_remitente_id = " + Properties.Settings.Default.idUsuario, "SI");
            if(ds.Tables[0].Rows.Count > 0)
            {
                
            }
        }

        private void cargarDatosTabla()
        {

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

        }
    }
}
