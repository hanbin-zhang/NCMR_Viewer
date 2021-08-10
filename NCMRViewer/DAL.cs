using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCMRViewer
{
   public static class DAL
    {
        public static DataTable LoadData(string SQL)
        {
            DataTable DT = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(Comm.ConnString);

                using (SqlCommand sc = new SqlCommand(SQL, conn))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(sc))
                    {
                        sda.Fill(DT);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }
            return DT;
        }
    }
}
