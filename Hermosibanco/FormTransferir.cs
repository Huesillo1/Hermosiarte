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
    public partial class FormTransferir : Form
    {
        BasedeDatos bd = new BasedeDatos();

        private string nombre, cuenta, miCuenta;

        public void setNombre(string value)
        {
            nombre = value;
        }

        public void setCuenta(string value)
        {
            cuenta = value;
        }

        public string getCuenta()
        {
            return cuenta;
        }

        public string getNombre()
        {
            return nombre;
        }
        private string getMiCuenta(string cuenta_saldo)
        {
            string[] array = cuenta_saldo.Split(' ');
            return array[0];
        }

        private void cargarMisCuentas()
        {
            DataSet ds = bd.consult("id,CONCAT(cuenta, ' | $', saldo) as cuenta_saldo", "cuentas_bancarias", "usuario_id = " + Properties.Settings.Default.idUsuario, "SI");
            if (ds.Tables[0].Rows.Count > 0)
            {
                cbbMisCuentas.DisplayMember = "cuenta_saldo";
                cbbMisCuentas.ValueMember = "id";
                cbbMisCuentas.DataSource = ds.Tables[0];                
            }
        }

        private void establecerMontoMaximo()
        {
            DataSet ds = bd.consult("saldo", "cuentas_bancarias", "cuenta = '" + getMiCuenta(cbbMisCuentas.GetItemText(cbbMisCuentas.SelectedItem)) + "'", "SI");
            if(ds.Tables[0].Rows.Count > 0)
            {
                txtMonto.Maximum = Decimal.Parse(ds.Tables[0].Rows[0]["saldo"].ToString());
            }
            else
            {
                cuenta = "";
                MessageBox.Show("No se pudo obtener tú saldo. Consulte con el administrador.");
            }
        }

        public FormTransferir()
        {
            InitializeComponent();
        }

        private void FormTransferir_Load(object sender, EventArgs e)
        {
            cargarMisCuentas();
            txtCuenta.Text = cuenta;
            txtNombre.Text = nombre;
            cbbMisCuentas.SelectedIndex = 0;
            establecerMontoMaximo();
        }

        private void cbbMisCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            establecerMontoMaximo();
            miCuenta = getMiCuenta(cbbMisCuentas.GetItemText(cbbMisCuentas.SelectedItem));
            //MessageBox.Show(cbbMisCuentas.GetItemText(cbbMisCuentas.SelectedItem));
        }

        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            btnTransferir.Enabled = false;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            double montoTransferencia = double.Parse(txtMonto.Value.ToString());
            if(miCuenta != "")
            {
                DataSet ds_emisor = bd.consult("saldo", "cuentas_bancarias","cuenta = '" + miCuenta + "'", "SI");
                DataSet ds_receptor = bd.consult("saldo", "cuentas_bancarias", "cuenta = '" + cuenta + "'", "SI");
                if(ds_emisor.Tables[0].Rows.Count > 0 && ds_receptor.Tables[0].Rows.Count > 0)
                {
                    //MessageBox.Show(ds_emisor.Tables[0].Rows[0]["saldo"].ToString() + "\n" + ds_receptor.Tables[0].Rows[0]["saldo"].ToString() + "\n\n___________________\n" + (double.Parse(ds_emisor.Tables[0].Rows[0]["saldo"].ToString()) - montoTransferencia).ToString() + "\n" + (double.Parse(ds_receptor.Tables[0].Rows[0]["saldo"].ToString()) + montoTransferencia).ToString());
                    bd.update("saldo = " + (double.Parse(ds_emisor.Tables[0].Rows[0]["saldo"].ToString()) - montoTransferencia).ToString(), "cuentas_bancarias", "cuenta = '" + miCuenta + "'", "SI");
                    bd.update("saldo = " + (double.Parse(ds_receptor.Tables[0].Rows[0]["saldo"].ToString()) + montoTransferencia).ToString(), "cuentas_bancarias", "cuenta = '" + cuenta + "'", "SI");
                    MessageBox.Show("Transferencia Exitosa!\n\nTú nuevo saldo es de $" + (double.Parse(ds_emisor.Tables[0].Rows[0]["saldo"].ToString()) - montoTransferencia).ToString(), "Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Value <= txtMonto.Maximum)
                btnTransferir.Enabled = true;
        }

        private void txtMonto_ValueChanged(object sender, EventArgs e)
        {
            btnTransferir.Enabled = false;
        }
    }
}
