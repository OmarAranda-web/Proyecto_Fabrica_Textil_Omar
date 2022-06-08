using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Fabrica_Textil_Omar
{
    internal class CONEXION_MAESTRA_OMAR_FA
    {
        static String servidor_omar_fa = "PC-OMARA";
        static String database_omar_fa = "FABRICA_ROPA_OMAR";
        static String seguridad_omar_fa = "true";
        static String usuario_omar_fa = "sa";
        static String contrasena_omar_fa = "omar261117";
        static String cadena_omar_fa = "DATA SOURCE=" + servidor_omar_fa + "; DATABASE=" + database_omar_fa + "; Integrated security= " + seguridad_omar_fa + "; USER ID =" + usuario_omar_fa + "; PASSWORD=" + contrasena_omar_fa;

        public static SqlConnection conectar_Omar_fa = new SqlConnection(cadena_omar_fa);
        public static SqlCommand consulta_omar_fa;
        public static SqlDataReader leer_omar_fa;
        
        public static void ConectarBDFabrica()
        {
            if (conectar_Omar_fa.State==ConnectionState.Closed)
            {
                conectar_Omar_fa.Open();
                consulta_omar_fa = new SqlCommand();
                consulta_omar_fa.Connection = conectar_Omar_fa;
                //MessageBox.Show("Se coneco a la base de datos ");
            }
        }
        public static void ejecutar_Omar_Fa(string Omar_sql)
        {
            consulta_omar_fa.CommandType = System.Data.CommandType.Text;
            consulta_omar_fa.CommandText = Omar_sql;
            leer_omar_fa = consulta_omar_fa.ExecuteReader();
        }
        public static void mostrar_Tabla_Omar(DataGridView tabla, string omar_sql)
        {
            ejecutar_Omar_Fa(omar_sql);
            leer_omar_fa.Close();
            DataSet cuadricula = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_omar_fa);
            adaptador.Fill(cuadricula, "datos");
            tabla.DataSource = cuadricula;
            tabla.DataMember = "datos";
            cuadricula.AcceptChanges();
        }
        public static void llenar_Combox_Omar(ComboBox Omar_Combo, string Omar_SQL)
        {
            ejecutar_Omar_Fa(Omar_SQL);
            Omar_Combo.Items.Clear();
            while (leer_omar_fa.Read())
            {
                Omar_Combo.Items.Add(leer_omar_fa[0]);
            }
            leer_omar_fa.Close();
        }
    }
}
