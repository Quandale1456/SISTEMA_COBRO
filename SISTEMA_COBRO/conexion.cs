using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SISTEMA_COBRO
{
    public class conexion
    {

        public class conexion1
        {
            //Cadena de conexion
            private static SqlConnection Conn = new SqlConnection("Data Source=LEURIPC\\SQLEXPRESS;Initial Catalog=PrestamosDB;Integrated Security=True");



            public static SqlConnection OctenerConexion()
            {
                return Conn;
            }
            //Metodo para Abrir Conexion
            public static void OpenConn()
            {
                try
                {
                    Conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            //Metodo para cerrar Conexion

            public static void CerrarCoon()
            {
                if (Conn != null)
                {
                    try
                    {
                        Conn.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

        }

    }

}
