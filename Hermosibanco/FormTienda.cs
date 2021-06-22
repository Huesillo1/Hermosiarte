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
    public partial class FormTienda : Form
    {
        BasedeDatos bd = new BasedeDatos();

        public FormTienda()
        {
            InitializeComponent();
        }

        private void FormTienda_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            DataSet ds = new DataSet();
            if (textBox1.TextLength > 0)
            {
                string busca = "descripcion LIKE '%" + textBox1.Text + "%'";
                ds = bd.consult("*", "articulos", busca, "SI");
            }
            else
            {
                try
                {
                    ds = bd.consult("*", "articulos", "", "NO");
                }
                catch(MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }                   
                
            }

            if (layoutProducts.Controls.Count > 0)
            {
                while(layoutProducts.Controls.Count > 0)
                {
                    layoutProducts.Controls.OfType<Product>().First().Dispose();
                }
            }

            DataTableReader data = ds.CreateDataReader();
            while (data.Read())
            {
                int id = Convert.ToInt32(data["id"]);
                string des = Convert.ToString(data["descripcion"]);
                int cant = Convert.ToInt32(data["cantidad"]);
                double prec = Convert.ToDouble(data["precio"]);
                string url = Convert.ToString(data["imagen"]);
                Product producto = new Product(id, des, cant, prec, url);
                producto.Margin = new Padding(15);
                layoutProducts.Controls.Add(producto);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            FormCart formcart = new FormCart();
            formcart.ShowDialog();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgregarItem formAgregarItem = new FormAgregarItem();
            formAgregarItem.ShowDialog();
        }
    }
}
