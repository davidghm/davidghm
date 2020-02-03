using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ejemplo_desconectado_mysql
{
  
        public static class bbdd
        {
         // Ip de la maquina, usuario y contraseña

            static string ruta = "SERVER=10.0.10.42;PORT=3306;DATABASE=concursomusica; UID=root; PASSWORD=root;";
        static MySqlConnection conection = new MySqlConnection(ruta);

        static MySqlCommand sqlcommand = new MySqlCommand();

        static MySqlDataAdapter da_concurso = new MySqlDataAdapter("select * from canciones", conection);
        //necesitamos un objeto dataadapter por cada tabla o consulta
        static MySqlDataAdapter da_grupos = new MySqlDataAdapter("select * from grupos", conection);
        //objeto dataset; almacenamiento de los datos.
        public static DataSet ds_concursomusica = new DataSet();

        public static DataView dw_grupos = new DataView();//=new DataView(ds_concursomusica.Tables[0]);
        public static DataView dw_canciones = new DataView();//=new DataView(ds_concursomusica.Tables[1]);

        static public void cargadatos()
        {
            conectar();
            //metodo fill;ejecuta la consulta y guarda los datos en el dataset indicado
            da_grupos.Fill(ds_concursomusica, "grupos");
            da_concurso.Fill(ds_concursomusica, "canciones");
            desconectar();
        }

        public static void conectar()
        {
            try
            {

                conection.Open();
                if (conection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Conectado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión\n" + ex.ToString());
            }
        }

        public static void desconectar()
        {
            try
            {
                conection.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public static MySqlDataReader consulta_select(string sql)
        {
            sqlcommand.Connection = conection;
            sqlcommand.CommandText = sql;
            // Para consultas de select
            return sqlcommand.ExecuteReader();


        }

        public static int consulta_no_select(string sql)
        {
            sqlcommand.Connection = conection;
            sqlcommand.CommandText = sql;
            // Consultas: update, insert, delete
            return sqlcommand.ExecuteNonQuery();


        }


    }
}


