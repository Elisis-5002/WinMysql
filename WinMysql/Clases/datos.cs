using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WinMysql.Clases
{
    internal class datos
    {
        string cadenaConexion = "server=localhost;user=luis;pwd=joseLuis";
        MySqlConnection conexion; 
        private void Conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }

        private void desconectar()
        {
            try
            {
                if(conexion= != null)
                {
                    conexion.Close();
                }

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
