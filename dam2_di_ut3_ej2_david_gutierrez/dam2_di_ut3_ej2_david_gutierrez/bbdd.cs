using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace dam2_di_ut3_ej2_david_gutierrez
{

    public static class bbdd
        {
        // Ip de la maquina, usuario y contraseña

        static string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Usuarios\\DAM215\\source\\repos\\T3\\ejemplo_conectado\\ejemplo_conectado\\Resources\\aseguradora.accdb;Persist Security Info=True";
        static OleDbConnection connection = new OleDbConnection(connectionstring);

        static OleDbCommand dbCommand = new OleDbCommand();

        public static DataSet ds_concursomusica = new DataSet();

        public static DataView dw_grupos = new DataView();//=new DataView(ds_concursomusica.Tables[0]);
        public static DataView dw_canciones = new DataView();//=new DataView(ds_concursomusica.Tables[1]);

        /*
         * clases:
         * Connection: establerer la conexion con la BBDD
         * Command: ejecutar las consultas en la BBDD
         * DATAREADER: Se almacenan los datos otenidosde las consultas
         */

        public static void conectar()
        {
            try
            {
                // para el estado de la conecxion ... connection.State==System.Data.ConnectionState
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("conectado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        public static void desconectar()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        public static OleDbDataReader consulta_select(string sql)
        {
            dbCommand.Connection = connection;
            dbCommand.CommandText = sql;
            //consultas select
            return dbCommand.ExecuteReader();//devuelve objeto datareader. Los objetos de la consulta que se ha generaod, por ejemplo de una consulta select.

        }

        public static int consulta_no_select(string sql)
        {
            dbCommand.Connection = connection;
            dbCommand.CommandText = sql;
            //consultas update, delete, insert.
            return dbCommand.ExecuteNonQuery(); // devuelve numero registros afectados, eejemplo 2 filas borradas o 4 filas actualizadas.

        }


    }
}


