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
    public partial class FormObservaciones : Form
    {
        BasedeDatos bd = new BasedeDatos();
        private string id_retiro;

        public void setIdRetiro(string value)
        {
            id_retiro = value;
        }

        public string getIdRetiro()
        {
            return id_retiro;
        }

        private void cargarObservaciones()
        {
            txtObservaciones.Text = bd.consult("observaciones", "retiros", "id = " + id_retiro, "SI").Tables[0].Rows[0]["observaciones"].ToString();
        }

        public FormObservaciones()
        {
            InitializeComponent();
        }

        private void FormObservaciones_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id_retiro) && !string.IsNullOrWhiteSpace(id_retiro))
                cargarObservaciones();
            else
                Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bd.update("observaciones  = '" + txtObservaciones.Text + "'", "retiros", "id = " + id_retiro, "SI");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo salió mal al intentar guardar las observaciones, reintente más tarde", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
