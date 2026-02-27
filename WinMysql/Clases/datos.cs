using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
    public DataSet ejecutar(string comando)
        {
            try
            {
                Conectar();
                MySqlDataAdapter dA = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                dA.Fill(ds);
                return ds; 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; 

            }
        }
