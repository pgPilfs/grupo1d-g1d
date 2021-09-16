using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using static MVCWebApi.Models.Cuenta;
using DcWallet_BackEnd.Models.Models;

namespace MVCWebApi.Models
{
    public class GestorCuenta
    {
        
        public void AltaCuenta(int clienteId, string tipoCuenta)
        {
            string connection = ConfigurationManager.ConnectionStrings["DBConn"].ToString();
            var cbu = GenerarCbu();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "CREAR CUENTA";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@IdCuenta", 12));
                comm.Parameters.Add(new SqlParameter("@TipoCuenta", tipoCuenta));
                comm.Parameters.Add(new SqlParameter("@ClienteId", clienteId));
                comm.Parameters.Add(new SqlParameter("@CBU", cbu));

                comm.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// Busca cuenta por CBU. Si encuentra devuelve la cuenta, si no devuelve null
        /// </summary>
        /// <param name="cbu"></param>
        /// <returns></returns>
        public Cuenta ObtenerxCbu(string cbu)
        {
            string connection = ConfigurationManager.ConnectionStrings["DBConn"].ToString();
            Cuenta cuenta = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Obtener_Cbu";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@cbu", cbu));

                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    var Id = dr.GetInt32(0);
                    var IdCliente1 = dr.GetInt32(1);
                    var Tipo_Cuenta1 = dr.GetString(2).Trim();
                    var CBU = dr.GetString(3);

                    cuenta = new Cuenta(Id, IdCliente1, CBU, Tipo_Cuenta1);


                    dr.Close();
                }
            }
            return cuenta;
        }

        //Baja Cuenta

        public void EliminarCuenta(int Id1)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["DBConn"].ToString();

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("BAJA-CUENTA", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@IdCuenta", Id1));

                comm.ExecuteNonQuery();
            }

        }

        //Obtener saldo 

        public decimal ObtenerSaldo(int idCuenta)
        {

            string StrConn = ConfigurationManager.ConnectionStrings["DBConn"].ToString();
            decimal saldo = 0;

            using (SqlConnection connec = new SqlConnection(StrConn))
            {
                connec.Open();

                SqlCommand comm = new SqlCommand("MOSTRAR SALDO", connec);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@idCuenta", idCuenta));

                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    saldo = reader.GetDecimal(4);
                }

            }
            return saldo;
        }

        //mostrar cuenta y ultimos movimientos 
        public Cuenta ObtenerCuenta(int Id1)
        {
            Cuenta Cuenta = null;
            Movimiento movimiento = null;
            List<Movimiento> lista = new List<Movimiento>();



            string StrConn = ConfigurationManager.ConnectionStrings["DBConn"].ToString();

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "MOSTRAR CUENTA";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@idCuenta", Id1));

                SqlDataReader dr = comm.ExecuteReader();

                if (dr.Read())
                {
                    var Id = dr.GetInt32(1);
                    var IdCliente1 = dr.GetInt32(2);
                    var Tipo_Cuenta1 = dr.GetString(3).Trim();
                    var CBU = dr.GetString(4);

                    Cuenta = new Cuenta(Id, IdCliente1, CBU, Tipo_Cuenta1);

                    comm = conn.CreateCommand();
                    comm.CommandText = "LISTAR MOVIMIENTOS";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add(new SqlParameter("@idCuenta", Id1));
                    dr.Close();
                    dr = comm.ExecuteReader();

                    while (dr.Read())
                    {
                        DateTime fechahora = dr.GetDateTime(2);
                        double monto = dr.GetDouble(3);
                        int idCuenta = dr.GetInt32(4);
                        int cuentaExternaId = dr.IsDBNull(5) ? dr.GetInt32(5) : 0;
                        string tipoMovimiento = dr.GetString(6).Trim();
                        movimiento = new Movimiento(fechahora, monto, idCuenta, cuentaExternaId, tipoMovimiento);
                        Cuenta.Movimientos.Add(movimiento);


                    }
                    dr.Close();

                }

            }

            return Cuenta;
        }
    
        public string GenerarCbu()
        {
            var random = new Random();

            string numero = "";

            Cuenta cuenta = null;
            do
            {
                numero = "";
                for (int i = 0; i < 20; i++)
                {
                    numero += random.Next(0, 9).ToString();
                }
                cuenta = ObtenerxCbu(numero);

            } while (cuenta != null);

            return numero;
        }

    }
}
