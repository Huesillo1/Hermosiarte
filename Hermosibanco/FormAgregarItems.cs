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
    
    public partial class FormAgregarItems : Form
    {
        public FormAgregarItems()
        {
            InitializeComponent();
        }
        // VARIABLES
        BasedeDatos bd = new BasedeDatos();
        string tabla = "articulos";
        string campos = "descripcion, cantidad, precio, status, fecha_registro, fecha_modificacion, imagen";
        string _descripcion;
        string _cantidad;
        string _precio;
        string _status;
        string _fecha_registro;
        string _fecha_modificacion;
        string _imagen;

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            
            // OBTENIENDO INFORMACION
            _descripcion = DescripcionTextBox.Text.ToString();
            _cantidad = CantidadUpDown.Value.ToString();
            _precio = PrecioUpDown.Value.ToString();
            _status = DisponibleCheckBox.Enabled ? "DISPONIBLE" : "NO DISPONIBLE";
            _fecha_registro = DateTime.Now.ToString("yyyy-MM-dd");
            _fecha_modificacion = DateTime.Now.ToString("yyyy-MM-dd");
            _imagen = LinkTextBox.Text.ToString();

            string valores = "'" + _descripcion + "', " + "'" + _cantidad + "', " + "'" + _precio + "', " + "'" + _status + "', " + "'" + _fecha_registro + "', " + "'" + _fecha_modificacion + "', " + "'" + _imagen + "'";

            // REALIZANDO LA QUERY
            //bd.insert(tabla, campos, valores);

            try
            {
                bd.insert(tabla, campos, valores);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "MySQL Exception");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }

           

        }
    }
}
