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
    public partial class FormBusquedaCompra : Form
    {
        BasedeDatos bd = new BasedeDatos();

        // USUARIO HARDCODEADO (SE DEBE DE TRAER DESDE EL LOGIN) USAR Settings.Default.usuarioId
        string usuarioID = "10";

        //PARA ALMACENAR LOS DATOS OBTENIDOS DE LA QUERY
        string _total;
        string _fecha_creacion;
        string _status;
        string _id;

        public FormBusquedaCompra()
        {
            InitializeComponent();
            string id = IDTextBox.Text.ToString();
            DataSet ds = new DataSet();
            //string campos = "id, usuario_id, total, fecha_creacion, status";
            string tabla = "carrito";
            string WHERE = "usuario_id = " + usuarioID;
            try
            {
                ds = bd.consult("*", tabla, WHERE, "SI");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DatosGridView.Rows.Add();
                        _total = ds.Tables[0].Rows[i]["total"].ToString();
                        _fecha_creacion = ds.Tables[0].Rows[i]["fecha_creacion"].ToString();
                        _status = ds.Tables[0].Rows[i]["status"].ToString();
                        _id = ds.Tables[0].Rows[i]["id"].ToString();

                        DatosGridView.Rows[i].Cells[0].Value = _id;
                        //DatosGridView.Rows[i].Cells[1].Value = usuarioID;
                        DatosGridView.Rows[i].Cells[1].Value = _total;
                        // SEPARANDO LA FECHA DE LA HORA
                        string[] sinHora = _fecha_creacion.Split(' ');
                        // -----------------------------
                        DatosGridView.Rows[i].Cells[2].Value = sinHora[0];
                        DatosGridView.Rows[i].Cells[3].Value = _status;

                    }

                }
                else
                    MessageBox.Show("No se pudieron recuperar los datos", "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            //FECHA
            string fecha = FiltroFecha.Value.ToString("yyyy-MM-dd");
            
            string id = IDTextBox.Text.ToString();
            DataSet ds = new DataSet();
            string campos = "id, usuario_id, total, fecha_creacion, status";
            string tabla = "carrito";
            string WHERE = "fecha_creacion = " + '\u0022' + fecha + '\u0022';
            Console.WriteLine(WHERE);
            try
            {
                ds = bd.consult("*", tabla, WHERE, "SI");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DatosGridView.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DatosGridView.Rows.Add();
                        _total = ds.Tables[0].Rows[i]["total"].ToString();
                        _fecha_creacion = ds.Tables[0].Rows[i]["fecha_creacion"].ToString();
                        
                        _status = ds.Tables[0].Rows[i]["status"].ToString();
                        _id = ds.Tables[0].Rows[i]["id"].ToString();

                        DatosGridView.Rows[i].Cells[0].Value = _id;
                        //DatosGridView.Rows[i].Cells[1].Value = usuarioID;
                        DatosGridView.Rows[i].Cells[1].Value = _total;
                        // SEPARANDO LA FECHA DE LA HORA
                        string[] sinHora = _fecha_creacion.Split(' ');
                        // -----------------------------
                        DatosGridView.Rows[i].Cells[2].Value = sinHora[0];
                        DatosGridView.Rows[i].Cells[3].Value = _status;

                    }

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

        private void button1_Click(object sender, EventArgs e)
        {
            string _id = IDTextBox.Text.ToString();
            Form toDetalleCompra = new FormDetalleCompra(_id);
            toDetalleCompra.Show();
        }
        private void FormBusquedaCompra_Load(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void DatosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DatosGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("AAA");
            //Console.WriteLine("ColumnIndex: " + e.ColumnIndex);
            //Console.WriteLine("RowIndex: " + e.RowIndex);
            /*
            if (IsANonHeaderLinkCell(e))
            {
                Funcion(e);
                Form toDetalleCompra = new FormDetalleCompra(_id);
                toDetalleCompra.Show();
                Console.WriteLine("ColumnIndex: " + e.ColumnIndex);
                Console.WriteLine("RowIndex: " + e.RowIndex);
            }
            else
            {
                Console.WriteLine("XXXXX");
            }

            void Funcion(DataGridViewCellEventArgs _e)
            {
                string idSeleccionado;
                idSeleccionado = DatosGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


                string _id = IDTextBox.Text.ToString();
                Form toDetalleCompra = new FormDetalleCompra(_id);
                toDetalleCompra.Show();
            }

            bool IsANonHeaderLinkCell(DataGridViewCellEventArgs cellEvent)
            {
                if (DatosGridView.Columns[cellEvent.ColumnIndex] is
                    DataGridViewLinkColumn &&
                    cellEvent.RowIndex != -1)
                { return true; }
                else { return false; }
            }
            */
        }

        private void DatosGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ColumnIndex: " + e.ColumnIndex);
            Console.WriteLine("RowIndex: " + e.RowIndex);

            // MOSTRAR SIEMPRE EL ID DE LA FILA
            string idColumna = DatosGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(idColumna);

            Form toDetalleCompra = new FormDetalleCompra(idColumna);
            toDetalleCompra.Show();

        }
    }
}

