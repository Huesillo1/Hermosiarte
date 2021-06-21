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
            string campos = "descripcion AS " + '\u0022' + "Descripcion del articulo" + '\u0022' + "," +
                            "carrito.fecha_creacion AS " + '\u0022' + "Fecha de Compra" + '\u0022' + "," +
                            "carrito_articulos.cantidad," +
                            "carrito_articulos.precio_unitario," +
                            "carrito.total";
            string tabla = "carrito_articulos JOIN carrito ON carrito_id = carrito.id JOIN articulos ON articulo_id = articulos.id";
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Orange;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = this.BackColor;
        }

        private void FormDetalleCompra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
