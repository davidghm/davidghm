using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dam2_di_ut3_ej2_david_gutierrez
{
    public partial class Form1 : Form
    {
        public String nombrecanciones;
        public String nombregrupos;
        DataTable dt1;
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bbdd.cargadatos();
            dataGridView1.DataSource = bbdd.ds_concursomusica.Tables[0];
            dt1 = new DataTable();
            dt1 = bbdd.ds_concursomusica.Tables[0];

            //DataTable dt2 = new DataTable();
            //dt2 = bbdd.ds_concursomusica.Tables[1];
            //combo.Items.Add(dt1.TableName);
            //combo.Items.Add(dt2.TableName);
            foreach (DataTable dt in bbdd.ds_concursomusica.Tables)
            {
                combo.Items.Add(dt.TableName);
            }
            DataRow fila;
            fila = dt1.Rows[0];

            bbdd.ds_concursomusica.Tables[0].Rows[0].ItemArray.ToString();

            bbdd.dw_grupos.Table = bbdd.ds_concursomusica.Tables[0];
            String filtro = "";

            //filtrado de los datos.
            bbdd.dw_grupos.RowFilter = filtro;

            //ordenacion de datos
            bbdd.dw_grupos.Sort = "";

            bbdd.dw_canciones.Table = bbdd.ds_concursomusica.Tables[1];

            //filtrado de los datos.
            bbdd.dw_grupos.RowFilter = filtro;

            //ordenacion de datos
            bbdd.dw_grupos.Sort = "";
            //asi cada tablename te coge una letra del nombre
            //for (int i = 0; i < dt1.TableName.Length; i++)
            //{
            //     nombrecanciones=nombrecanciones+ dt1.TableName[i];
            //}
            //for (int i = 0; i < dt2.TableName.Length; i++)
            //{
            //    nombregrupos = nombregrupos + dt2.TableName[i];
            //}
            //combo.Items.Add(nombrecanciones);
            //combo.Items.Add(nombregrupos);
            combo.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bbdd.ds_concursomusica.Tables[combo.SelectedItem.ToString()];
            lBox_notIncluded.Items.Clear();
            lBox_included.Items.Clear();
            for (int i = 0; i < bbdd.ds_concursomusica.Tables[combo.SelectedItem.ToString()].Columns.Count; i++)
            {
                lBox_notIncluded.Items.Add(bbdd.ds_concursomusica.Tables[combo.SelectedItem.ToString()].Columns[i].ToString());
            }
        }

        private void Rbtn_entre1020_CheckedChanged(object sender, EventArgs e)
        {
            String filtro = "codgrupo > 10 and codgrupo<20";
            bbdd.dw_grupos.RowFilter = filtro;
            dataGridView1.DataSource = bbdd.dw_grupos;
        }

        private void Rbtn_comienzaporA_CheckedChanged(object sender, EventArgs e)
        {
            String filtro = "nombre like 'A%'";
            bbdd.dw_grupos.RowFilter = filtro;
            dataGridView1.DataSource = bbdd.dw_grupos;
        }

        private void Rbtn_madridbarcelona_CheckedChanged(object sender, EventArgs e)
        {
            String filtro = "localidad ='Madrid' or localidad='Barcelona'";
            bbdd.dw_grupos.RowFilter = filtro;
            dataGridView1.DataSource = bbdd.dw_grupos;
        }

        private void Rbtn_mas2010yBarcelona_CheckedChanged(object sender, EventArgs e)
        {
            String filtro = "localidad ='Barcelona' and fechaEstreno>#01/01/2010#";
            bbdd.dw_grupos.RowFilter = filtro;
            dataGridView1.DataSource = bbdd.dw_grupos;
        }

        private void Btn_toLeft_Click(object sender, EventArgs e)
        {
            object item = lBox_included.SelectedItem;
            lBox_included.Items.Remove(item);
            lBox_notIncluded.Items.Add(item);
        }

        private void Btn_toRight_Click(object sender, EventArgs e)
        {
            object item = lBox_notIncluded.SelectedItem;
            lBox_notIncluded.Items.Remove(item);
            lBox_included.Items.Add(item);
        }

        private void Btn_order_Click(object sender, EventArgs e)
        {
            String orden = "";
            for (int i = 0; i < lBox_included.Items.Count; i++)
            {
                orden += lBox_included.Items[i].ToString() + ",";
            }
            orden = orden.TrimEnd(',');
            switch (combo.SelectedItem.ToString())
            {
                case "grupos":
                    bbdd.dw_grupos.Sort = orden;
                    dataGridView1.DataSource = bbdd.dw_grupos;
                    break;
                case "canciones":
                    bbdd.dw_canciones.Sort = orden;
                    dataGridView1.DataSource = bbdd.dw_canciones;
                    break;
            }           
            
        }
    }
}
