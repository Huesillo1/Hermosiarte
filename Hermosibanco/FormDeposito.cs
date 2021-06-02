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
    public partial class FormDeposito : Form
    {
        BasedeDatos bd = new BasedeDatos();

        private string idusuario;
        private string cuenta;
        private string nombre;

        public void setIdUsuario(string value)
        {
            idusuario = value;
        }

        public string getIdUsuario()
        {
            return idusuario;
        }

        public void setCuenta(string value)
        {
            cuenta = value;
        }

        public void setNombre(string value)
        {
            nombre = value;
        }
        public FormDeposito()
        {
            InitializeComponent();
        }

        private void FormDeposito_Shown(object sender, EventArgs e)
        {
            txtNombre.Text = nombre;
            txtCuenta.Text = cuenta;
            txtFecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataSet ds = bd.consult("id, saldo", "cuentas_bancarias", "cuenta = '" + cuenta + "'", "SI");
            if (ds.Tables[0].Rows.Count > 0)
            {
                double saldo = Double.Parse(ds.Tables[0].Rows[0]["saldo"].ToString());
                saldo += Double.Parse(txtMonto.Value.ToString());
                if (bd.update("saldo =" + saldo.ToString(), "cuentas_bancarias", "cuenta = '" + cuenta + "'", "SI"))
                {
                    MessageBox.Show("El nuevo saldo actual es de $" + saldo.ToString(), "Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bd.insert("movimientos", "cantidad,concepto,cuenta_bancaria_id,emisor_id,receptor_id,fecha,tipo", txtMonto.Value.ToString() + ", 'DEPOSITO A CUENTA PROPIA', " + ds.Tables[0].Rows[0]["id"].ToString() + ", 0, " + idusuario + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 'DEPOSITO'");
                }                    
                else
                    MessageBox.Show("Algo salió mal con la transacción.\nIntente más tarde.", "Transacción fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
