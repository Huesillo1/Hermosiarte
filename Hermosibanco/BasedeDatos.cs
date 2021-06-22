using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Hermosibanco
{
    class BasedeDatos
    {
        #region "Variables MySQL"
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataReader reader;

        private string consultaSQL;
        #endregion

        private bool _createConnection()
        {
            string servidor = "127.0.0.1";
            string bd = "hermosiarte";
            string usuario = "root";
            string password = "";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password;

            connection.ConnectionString = cadenaConexion;
            return true;
        }

        private bool _openConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
                connection.Open();
            }
            return true;
        }

        private bool _closeConnection()
        {
            connection.Close();
            return true;
        }

        /// <summary>
        /// Realizas una prueba de conexion para comprobar que se conecte correctamente a mysql
        /// </summary>
        /// <returns>True or False</returns>
        public bool testConnection()
        {
            try
            {
                _createConnection();
                _openConnection();
                _closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fallo al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _closeConnection();
                return false;
            }
        }

        /// <summary>
        /// Realiza una operacion basica de mysql, no devuelve conjunto de datos SELECT
        /// </summary>
        /// <param name="_SQL_syntax">UPDATE _tabla_ SET _campo_ = '_valor_' WHERE _campo_ = '_valor_'</param>
        /// <returns>True or False</returns>
        public bool generalCommands(string _SQL_syntax)
        {
            try
            {
                _createConnection();
                _openConnection();

                //realizamos cualquier operación básica (INSERT, UPDATE, DELETE)

                command.Connection = connection;
                command.CommandText = _SQL_syntax;

                command.ExecuteNonQuery();

                _closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\n" + command.CommandText, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _closeConnection();
                return false;
            }
        }
        /// <summary>
        /// Realiza una consulta a la base de datos 
        /// </summary>
        /// <param name="campos">(campo1, campo2, campo3, campoN, ...)</param>
        /// <param name="tabla">_nombre_tabla_</param>
        /// <param name="clausula_where">_campo_ = '_coincide_'</param>
        /// <param name="opcion_where">SI o NO</param>
        /// <returns>DataSet</returns>
        public DataSet consult(string campos, string tabla, string clausula_where, string opcion_where)
        {
            _createConnection();
            _openConnection();

            DataSet data = null;
            string consult = "";

            if (opcion_where == "SI")
                consult = "SELECT " + campos + " FROM " + tabla + " WHERE " + clausula_where;
            else
                consult = "SELECT " + campos + " FROM " + tabla;

            MySqlDataAdapter adapter = new MySqlDataAdapter(consult, connection);
            data = new DataSet();
            adapter.Fill(data, tabla);

            _closeConnection();

            return data;

            //Entrar a foro, abrir un nuevo tema de foro, contestar la pregunta qué es h5p
        }

        /// <summary>
        /// Ingresa un registro a la base de datos
        /// </summary>
        /// <param name="tabla">_nombre_tabla_</param>
        /// <param name="campos">(campo1, campo2, campo3, campoN, ...)</param>
        /// <param name="values">('_value1_','_value2_','_value3_', '_valueN_',...)</param>
        /// <returns>True or False</returns>
        public bool insert(string tabla, string campos, string values)
        {
            try
            {
                _createConnection();
                _openConnection();

                campos = campos.Replace("(", "");
                campos = campos.Replace(")", "");
                values = values.Replace("(", "");
                values = values.Replace(")", "");

                ///REALIZAMOS EL INSERT
                command.Connection = connection;
                command.CommandText = "INSERT INTO " + tabla + "(" + campos + ") VALUES (" + values + ");";
                command.ExecuteNonQuery();

                _closeConnection();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\n" + command.CommandText, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _closeConnection();
                return false;
            }
        }

        /// <summary>
        /// Realiza una actualización a la base de datos
        /// </summary>
        /// <param name="campos_set">(campo1, campo2, campo3, campoN, ...)</param>
        /// <param name="tabla">_nombre_tabla_</param>
        /// <param name="campo_where">_campo_ = '_coincide_'</param>
        /// <param name="opcion_where">SI o NO</param>
        /// <returns>True or False</returns>
        public bool update(string campos_set, string tabla, string campo_where, string opcion_where)
        {
            _createConnection();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = connection;
            if (opcion_where == "SI")
                cmd.CommandText = "UPDATE " + tabla + " SET " + campos_set + " WHERE " + campo_where;
            else
                cmd.CommandText = "UPDATE " + tabla + " SET " + campos_set; ;

            try
            {
                _openConnection();
                cmd.ExecuteNonQuery();
                _closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\n" + cmd.CommandText, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _closeConnection();
                return false;
            }
        }

        /// <summary>
        /// Realiza una eliminacion a la base de datos
        /// </summary>
        /// <param name="tabla">_nombre_tabla_</param>
        /// <param name="where">_campo_</param>
        /// <param name="id">_valor_</param>
        /// <returns>True o False</returns>
        public bool delete(string tabla, string where, string id)
        {
            MySqlCommand cmd = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM " + tabla + " WHERE " + where + " = @id";
            command.Parameters.Add(new MySqlParameter("@id", id));

            _openConnection();

            try
            {
                cmd.ExecuteNonQuery();
                _closeConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\n" + cmd.CommandText, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _closeConnection();
                return false;
            }
        }

        /// <summary>
        /// Obtienes el id del ultimo registro almacenado
        /// </summary>
        /// <param name="id">_valor_</param>
        /// <param name="as_">_as_field_name_</param>
        /// <param name="tabla">_nombre_tabla_</param>
        /// <returns>Int</returns>
        public int lastRecord(string id, string as_, string tabla)
        {
            int ultimo = 0;
            DataSet data = null;
            _createConnection();
            _openConnection();

            consultaSQL = "SELECT MAX(" + id + ") as " + as_ + " FROM " + tabla;
            MySqlDataAdapter adapter = new MySqlDataAdapter(consultaSQL, connection);
            data = new DataSet();
            adapter.Fill(data, tabla);
            _closeConnection();
            if (data.Tables[0].Rows.Count > 0)
                ultimo = Int32.Parse(data.Tables[0].Rows[0][as_].ToString());
            return ultimo;
        }
    }
}
