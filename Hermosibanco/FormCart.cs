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
    public partial class FormCart : Form
    {
        BasedeDatos bd = new BasedeDatos();
        private string idCarrito;
        double total = 0;

        public FormCart()
        {
            InitializeComponent();
        }

        private void buyCart_Click(object sender, EventArgs e)
        {
            DataSet ds, dss, dsss;
            double saldo;
            int articulo_id, cantidad, cantidadFinal;
            string where4, where5;
            string where2 = "usuario_id = " + "'" + Properties.Settings.Default.idUsuario + "'";
            ds = bd.consult("saldo", "cuentas_bancarias", where2, "SI");
            saldo = Convert.ToDouble(ds.Tables[0].Rows[0]["saldo"]);
            if (saldo < total)
                MessageBox.Show("No tienes suficiente saldo");
            else
            {
                saldo -= total;
                string values2;
                string saldo2 = "saldo = '" + saldo + "'";
                bd.update(saldo2, "cuentas_bancarias", where2, "SI");
                string where = "usuario_id = " + "'" + Properties.Settings.Default.idUsuario + "' " + "AND status = 'PENDIENTE'";
                string a = "status = 'COMPLETADA'";
                bd.update(a, "carrito", where, "SI");
                string where3 = "carrito_id = '" + idCarrito + "'";
                string values = Properties.Settings.Default.idUsuario + ", '" + total + "', 'COMPLETADA', '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                bd.insert("compras", "id_usuario, importe, status, fecha", values);
                dsss = bd.consult("id", "compras ORDER BY id DESC LIMIT 1", "", "NO");
                int idCompra = Convert.ToInt32(dsss.Tables[0].Rows[0]["id"]);

                ds = bd.consult("articulo_id, cantidad", "carrito_articulos", where3, "SI");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    articulo_id = Convert.ToInt32(ds.Tables[0].Rows[i]["articulo_id"]);
                    cantidad = Convert.ToInt32(ds.Tables[0].Rows[i]["cantidad"]);

                    values2 = "'" + idCompra + "', '" + articulo_id + "', '" + cantidad + "'";
                    bd.insert("historial_articulos_compras", "compra_id, articulo_id, cantidad", values2);
                    
                    where4 = "id = '" + articulo_id + "'";
                    dss = bd.consult("cantidad", "articulos", where4, "SI");
                    cantidadFinal = Convert.ToInt32(dss.Tables[0].Rows[0]["cantidad"]) - cantidad;
                    where5 = "cantidad = '" + cantidadFinal + "'";
                    bd.update(where5, "articulos", where4, "SI");
                }

                this.Close();
                MessageBox.Show("Compra realizada");
            } 
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            DataSet ds;
            string where = "usuario_id = " + "'" + Properties.Settings.Default.idUsuario + "' " + "AND status = 'PENDIENTE'";
            ds = bd.consult("*", "carrito", where, "SI");

            if (ds.Tables[0].Rows.Count > 0)
            {
                total = Convert.ToDouble(ds.Tables[0].Rows[0]["total"]);
                precioLabel.Text = "$" + Convert.ToString(ds.Tables[0].Rows[0]["total"]);
                idCarrito = Convert.ToString(ds.Tables[0].Rows[0]["id"]);
            }
            else
            {
                label1.Visible = false;
                buyCart.Visible = false;
                deleteCart.Visible = false;
            }
        }

        private void deleteCart_Click(object sender, EventArgs e)
        {
            string where = "carrito_id = '" + idCarrito + "'";
            string where2 = "id = '" + idCarrito + "'";
            bd.delete("carrito_articulos", where, "");
            bd.delete("carrito", where2, "");
            MessageBox.Show("Carrito vaciado");
            this.Close();
        }

        private void closeCart_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
