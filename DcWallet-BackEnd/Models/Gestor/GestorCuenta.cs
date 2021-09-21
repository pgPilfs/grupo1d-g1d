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
        
        public int AltaCuenta(Cuenta cuenta)
        {
            var cbu = GenerarCbu();
            

            string connection = ConfigurationManager.ConnectionStrings["DBConn"].ToString();
             

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "CREAR CUENTA";
                comm.CommandType = CommandType.StoredProcedure;
                //comm.Parameters.Add(new SqlParameter("@IdCuenta", ));
                comm.Parameters.Add(new SqlParameter("@IdCliente", cuenta.IdCliente1));
                comm.Parameters.Add(new SqlParameter("@TipoCuenta", cuenta.Tipo_Cuenta1));
                comm.Parameters.Add(new SqlParameter("@CBU", cbu));

                //comm.ExecuteNonQuery();
                return Convert.ToInt32(comm.ExecuteScalar());

            }
        }



        //variable Total para calcular el saldo de la cuenta
        
        /// <summary>
        /// Busca cuenta por CBU. Si encuentra devuelve la cuenta, si no devuelve null
        /// </summary>
        /// <param name="cbu"></param>
        /// <returns></returns>
        public Cuenta ObtenerxCbu(string CBU)
        {
            string connection = ConfigurationManager.ConnectionStrings["DBConn"].ToString();
            Cuenta cuenta = null;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Obtener_Cbu";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@cbu", CBU));

                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    var Id = dr.GetInt32(0);
                    var IdCliente1 = dr.GetInt32(1);
                    var Tipo_Cuenta1 = dr.GetString(2).Trim();
                    var cbu = dr.GetString(3).Trim();
                    

                    cuenta = new Cuenta(Id, IdCliente1, cbu, Tipo_Cuenta1);


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
                    var Id = dr.GetInt32(0);
                    var IdCliente1 = dr.GetInt32(1);
                    var Tipo_Cuenta1 = dr.GetString(2).Trim();
                    var CBU = dr.GetString(3).Trim();
                    //var saldo = Total;

                    Cuenta = new Cuenta(Id, IdCliente1, CBU, Tipo_Cuenta1);

                    comm = conn.CreateCommand();
                    comm.CommandText = "LISTAR MOVIMIENTOS";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.Add(new SqlParameter("@idCuenta", Id1));
                    dr.Close();
                    dr = comm.ExecuteReader();

                    while (dr.Read())
                    {
                        DateTime fechahora = dr.GetDateTime(1);
                        decimal monto = dr.GetDecimal(2);
                        int idCuenta = dr.GetInt32(3);
                        int cuentaExternaId = 0;
                        //int cuentaExternaId = dr.IsDBNull(5) ? dr.GetInt32(5) : 0;
                        int tipoMovimiento = dr.GetInt32(4);
                        decimal SaldoTotal = calcSaldo(tipoMovimiento, monto);

                        movimiento = new Movimiento(fechahora, monto, idCuenta, cuentaExternaId, tipoMovimiento, SaldoTotal);
                        Cuenta.Movimientos.Add(movimiento);

                        

                    }
                    dr.Close();


                }

            }

            return Cuenta;
        }

        public decimal calcSaldo(int tipomovi , decimal monto)
        {
            decimal Total = 0;
            // 1 = Extraccion 2 = Deposito si es null es porque no hay movimientos 
            if (tipomovi == 1)
            {
                Total = Total - monto;
            }
            else if (tipomovi == 2)
            {
                Total = Total + monto;
            }
            else
            {
                Total = Total + 0;
            }

            return Total;
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
