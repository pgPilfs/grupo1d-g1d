using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;            

namespace DC_Wallet_BackEnd.Models
{
    public class GestorDeposito
    {
        public Deposito OperacionDeposito(Deposito ingresar)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
         

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Realizar_OperacionDeposito";
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@Nombre", "Deposito"));
                comm.Parameters.Add(new SqlParameter("@Monto", ingresar.Monto));//le paso el valor de la base de datos que recibe el objecto ingresar y las propiedades del modelo
                comm.Parameters.Add(new SqlParameter("@IdCliente", ingresar.IdCliente));
                comm.Parameters.Add(new SqlParameter("@IdCuenta", ingresar.IdCuenta));

                ingresar.IdCuenta = Convert.ToInt32(comm.ExecuteScalar());
                ingresar.TipoMovimientos = "Deposito";
                

            }
            return ingresar;

        }
    }
}