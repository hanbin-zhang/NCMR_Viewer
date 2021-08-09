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
        public static DataTable LoadData()
        {
            DataTable DT = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(Comm.ConnString);

                string SQL = "SELECT TOP (50) *, NCMR_NO + '.jpg' AS ScanImage FROM [NCMR].[dbo].[NCMR_MAIN]";
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
