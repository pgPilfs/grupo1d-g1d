using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace DC_Wallet_BackEnd.Models
{
    public class GestorTransferencia
    {
        public Transferencia OperacionTransferir(Transferencia transferir)
        {
            string StrConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Realizar_OperacionTranferir";
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@Nombre", "Transferencia"));
                comm.Parameters.Add(new SqlParameter("@Monto", transferir.Monto));
                comm.Parameters.Add(new SqlParameter("@IdCuenta", transferir.IdCuenta));
                transferir.IdCuenta = Convert.ToInt32(comm.ExecuteScalar());
                transferir.TipoMovimientos = "Transferencia";


            }
            return transferir;
        }
    }
}