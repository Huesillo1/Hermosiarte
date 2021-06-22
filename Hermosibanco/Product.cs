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
    public partial class Product : UserControl
    {
        private int ID;
        private string descr;
        private int cantidad;
        private double precio;
        private string url;
        BasedeDatos bd = new BasedeDatos();

        public Product(int id, string description, int quantity, double price, string imagen)
        {
            InitializeComponent();
            ID = id;
            descr = description;
            cantidad = quantity;
            precio = price;
            url = imagen;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            pictureBox1.ImageLocation = url;
            description.Text = descr;
            price.Text = "$" + precio.ToString();
            cant.Text = cant.Text + " " + cantidad.ToString();
            cantCart.Maximum = cantidad;
            if (cantCart.Value == 0)
                addCart.Enabled = false;
        }

        private void addCart_Click(object sender, EventArgs e)
        {
            DataSet ds;
            double total = 0;
            double cantidad = Convert.ToDouble(cantCart.Value);

            string where = "usuario_id = " + "'" + Properties.Settings.Default.idUsuario + "' " + "AND status = 'Pendiente'";
            ds = bd.consult("*", "carrito", where, "SI");

            if(ds.Tables[0].Rows.Count == 0)
            {
                string campos = "usuario_id, total, fecha_creacion, status";
                string values = "'" + Properties.Settings.Default.idUsuario + "', '" + cantidad * precio + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 'Pendiente'";
                bd.insert("carrito", campos, values);
            }
            else
            {
                ds = bd.consult("*", "carrito", where, "SI");
                total = Convert.ToDouble(ds.Tables[0].Rows[0]["total"]) + cantidad * precio;
                string a = "total = '" + total + "'";
                bd.update(a, "carrito", where, "SI");
            }

            ds = bd.consult("id", "carrito ORDER BY id DESC LIMIT 1", "", "NO");
            int idCart = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);

            string campos2 = "carrito_id, articulo_id, cantidad, precio_unitario";
            string values2 = "'" + idCart + "', '" + ID + "', '" + cantidad + "', '" + precio + "'";
            bd.insert("carrito_articulos", campos2, values2);

            MessageBox.Show("Agregado al carrito");
            cantCart.Value = 0;
        }

        private void cantCart_ValueChanged(object sender, EventArgs e)
        {
            if (cantCart.Value == 0)
                addCart.Enabled = false;
            else
                addCart.Enabled = true;
        }
    }
}
