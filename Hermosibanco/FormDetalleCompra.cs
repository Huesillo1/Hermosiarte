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
    public partial class FormDetalleCompra : Form
    {
        public FormDetalleCompra(string _idCompraFormAnterior)
        {
            InitializeComponent();

            //RECUPERAR EL ID DEL CARRITO DE FORM ANTERIOR
            string _idCompra = _idCompraFormAnterior;
            string _descripcion;
            string _fecha_compra;
            string _cantidad;
            string _precio_unitario;
            string _total;
            //-------------------------------------------------------------------
            DataSet ds = new DataSet();
            BasedeDatos bd = new BasedeDatos();
            string campos = "descripcion AS " + '\u0022' + "Descripcion del articulo" +'\u0022' + "," +
                            "carrito.fecha_creacion AS " + '\u0022' + "Fecha de Compra" + '\u0022' + "," +
                            "carrito_articulos.cantidad," +
                            "carrito_articulos.precio_unitario," +
                            "carrito.total";
            string tabla = "carrito_articulos left JOIN carrito ON carrito_id = carrito.id left join articulos ON articulo_id = articulos.id";
            string WHERE = "carrito_id =" + _idCompra;
            try
            {
                ds = bd.consult(campos, tabla, WHERE, "SI");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    InfoCompraGrid.Rows.Add();
                    _descripcion = ds.Tables[0].Rows[0]["Descripcion del articulo"].ToString();
                    _fecha_compra = ds.Tables[0].Rows[0]["Fecha de Compra"].ToString();
                    _cantidad = ds.Tables[0].Rows[0]["cantidad"].ToString();
                    _precio_unitario = ds.Tables[0].Rows[0]["precio_unitario"].ToString();
                    _total = ds.Tables[0].Rows[0]["total"].ToString();

                    InfoCompraGrid.Rows[0].Cells[0].Value = _descripcion;
                    // SEPARANDO LA FECHA DE LA HORA
                    string[] sinHora = _fecha_compra.Split(' ');
                    InfoCompraGrid.Rows[0].Cells[1].Value = sinHora[0];
                    InfoCompraGrid.Rows[0].Cells[2].Value = _cantidad;
                    InfoCompraGrid.Rows[0].Cells[3].Value = _precio_unitario;
                    InfoCompraGrid.Rows[0].Cells[4].Value = _total;

                }
                else
                    MessageBox.Show("Datos no encontrados", "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
