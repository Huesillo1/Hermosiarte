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
    public partial class FormTransferir : Form
    {
        BasedeDatos bd = new BasedeDatos();

        private string nombre, cuenta, miCuenta;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
                DataSet ds_emisor = bd.consult("id, saldo", "cuentas_bancarias","cuenta = '" + miCuenta + "'", "SI");
                DataSet ds_receptor = bd.consult("id, usuario_id, saldo", "cuentas_bancarias", "cuenta = '" + cuenta + "'", "SI");
                if(ds_emisor.Tables[0].Rows.Count > 0 && ds_receptor.Tables[0].Rows.Count > 0)
                {
                    //MessageBox.Show(ds_emisor.Tables[0].Rows[0]["saldo"].ToString() + "\n" + ds_receptor.Tables[0].Rows[0]["saldo"].ToString() + "\n\n___________________\n" + (double.Parse(ds_emisor.Tables[0].Rows[0]["saldo"].ToString()) - montoTransferencia).ToString() + "\n" + (double.Parse(ds_receptor.Tables[0].Rows[0]["saldo"].ToString()) + montoTransferencia).ToString());
                    bd.update("saldo = " + (double.Parse(ds_emisor.Tables[0].Rows[0]["saldo"].ToString()) - montoTransferencia).ToString(), "cuentas_bancarias", "cuenta = '" + miCuenta + "'", "SI");
                    bd.update("saldo = " + (double.Parse(ds_receptor.Tables[0].Rows[0]["saldo"].ToString()) + montoTransferencia).ToString(), "cuentas_bancarias", "cuenta = '" + cuenta + "'", "SI");
                    MessageBox.Show("Transferencia Exitosa!\n\nTú nuevo saldo es de $" + (double.Parse(ds_emisor.Tables[0].Rows[0]["saldo"].ToString()) - montoTransferencia).ToString(), "Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bd.insert("movimientos", "cantidad, concepto, cuenta_bancaria_id, cuenta_bancaria_emisor_id, emisor_id, receptor_id, fecha, tipo, estatus", txtMonto.Value.ToString() + ", 'TRANSFERENCIA A TERCEROS', " + ds_receptor.Tables[0].Rows[0]["id"].ToString() + ", " + ds_emisor.Tables[0].Rows[0]["id"].ToString() + ", " + Properties.Settings.Default.idUsuario + ", " + ds_receptor.Tables[0].Rows[0]["usuario_id"].ToString() + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 'TRANSFERENCIA', 'EXITOSA'");
                    Close();
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTransferir_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Orange;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = this.BackColor;
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
