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
    public partial class FormAgregarItem : Form
    {
        BasedeDatos bd = new BasedeDatos();
        

        private string ObtenerInformacion()
        {
            string descripcion = NombreTextBox.Text;
            string cantidad = CantidadUpDown.Value.ToString();
            string precio = PrecioUpDown.Value.ToString();
            string estado;
            if(DisponibleCheckBox.Checked)
                estado = "DISPONIBLE";
            else
                estado = "NO DISPONIBLE";

            string valores = "'" + descripcion + "', " + "'" + cantidad + "', " + "'" + precio + "', " + "'" + estado + "', " + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            // "'" + txtNombre.Text + "', " + "'" + txtApellidoPaterno.Text + "', " + "'" + apellidoMaterno + "', " + "'" + txtCalle.Text + "', " + "'" + txtNoExt.Text + "', " + "'" + noInt + "', " + "'" + txtCP.Text + "', " + "'" + cbbMunicipio.GetItemText(cbbMunicipio.SelectedItem).ToUpper() + "', " + "'" + cbbEstado.GetItemText(cbbEstado.SelectedItem).ToUpper() + "', " + "'" + dtFechaNacimiento.Value.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 'ACTIVO', '" + txtPuesto.Text + "', '" + txtUsuario.Text + "', '" + txtPassword.Text + "'";

            return valores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string campos = "descripcion, cantidad, precio, status, fecha_registro, fecha_modificacion";
            bd.insert("articulos", campos, ObtenerInformacion());

        }

        public FormAgregarItem()
        {
            InitializeComponent();
        }

        private void FormAgregarItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
