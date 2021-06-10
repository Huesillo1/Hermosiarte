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
    public partial class FormDetallesSolicitudRetiro : Form
    {
        BasedeDatos bd = new BasedeDatos();

        private void cargarCuentas()
        {
            DataSet ds = bd.consult("id, cuenta, CONCAT(cuenta, ' - $',saldo) AS cuenta_saldo", "cuentas_bancarias", "usuario_id = " + Properties.Settings.Default.idUsuario, "SI");
            if(ds.Tables[0].Rows.Count > 0)
            {
                cbbCuenta.DisplayMember = "cuenta_saldo";
                cbbCuenta.ValueMember = "id";
                cbbCuenta.DataSource = ds.Tables[0];
            }else
            {
                MessageBox.Show("No cuentas con niguna cuenta bancaria", "Error al obtener cuenta bancaria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private double getSaldo()
        {
            string[] array = cbbCuenta.GetItemText(cbbCuenta.SelectedItem).Split('$');
            try
            {
                return array[1] != "" ? double.Parse(array[1]) : 0.00;
            }
            catch(Exception ex)
            {
                return 0.00;
            }
            
        }

        private string generarClave()
        {
            Random numero = new Random();
            string clave = "";
            for (int i = 0; i < 16; i++)
                clave += numero.Next(0, 10).ToString();
            return clave;
        }

        private Boolean validarExisteClave(string clave)
        {
            DataSet ds = bd.consult("id", "retiros", "clave = '" + clave + "' AND status = 'PENDIENTE'", "SI");
            return ds.Tables[0].Rows.Count > 0;
        }

        public FormDetallesSolicitudRetiro()
        {
            InitializeComponent();
        }

        private void FormDetallesSolicitudRetiro_Load(object sender, EventArgs e)
        {
            cargarCuentas();
            txtCantidad.Maximum = Decimal.Parse(getSaldo().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbCuenta.SelectedValue.ToString());
            //MessageBox.Show(getSaldo(cbbCuenta.GetItemText(cbbCuenta.SelectedItem)).ToString());
        }

        private void cbbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidad.Maximum = Decimal.Parse(getSaldo().ToString());
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if(getSaldo() >= double.Parse(txtCantidad.Value.ToString()))
            {
                try
                {
                    bd.insert("movimientos", "cantidad, concepto, cuenta_bancaria_id, emisor_id, receptor_id, fecha, tipo, estatus", txtCantidad.Value.ToString() + ", '" + txtConcepto.Text + "', " + cbbCuenta.SelectedValue + ", 0, " + Properties.Settings.Default.idUsuario + ", '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', 'RETIRO', 'PENDIENTE'");
                    string clave = "";
                    do
                    {
                        clave = generarClave();
                    } while (validarExisteClave(clave));
                    bd.insert("retiros","movimiento_id, clave, usuario_solicita_id, status",bd.lastRecord("id", "id_movimiento", "movimientos").ToString() + ", '" + clave + "', " + Properties.Settings.Default.idUsuario + ", 'PENDIENTE'");
                    FormClaveRetiro formClaveRetiro = new FormClaveRetiro();
                    formClaveRetiro.setClaveRetiro(clave);
                    formClaveRetiro.ShowDialog();
                }     
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en Solicitar_Click()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No puedes retirar más de tu saldo actual", "Saldo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
