using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace DC_Wallet_BackEnd.Models
{
    public class GestorExtraer
    {
        public Extraer OperacionExtraer(Extraer extraer)
        {
            //Operaciones extraer = new Operaciones();
            string StrConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            extraer.FechaMovimientos = DateTime.Now;
            int IdCuenta;

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();

                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Realizar_OperacionExtraer";
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@IdTipoMovimientos", "Extraccion"));
                comm.Parameters.Add(new SqlParameter("@Monto", extraer.Monto));
                comm.Parameters.Add(new SqlParameter("@FechaMovimientos", extraer.FechaMovimientos));
                comm.Parameters.Add(new SqlParameter("@IdCuenta", extraer.IdCuenta));

                IdCuenta = Convert.ToInt32(comm.ExecuteScalar());
                extraer.TipoMovimientos = "Extraccion";
                extraer.IdCuenta = IdCuenta;


            }
            return extraer;
        }                   

    }
}