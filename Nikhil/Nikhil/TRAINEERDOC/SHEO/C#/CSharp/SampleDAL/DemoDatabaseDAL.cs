using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using SampleBO;

namespace SampleDAL
{
    public class DemoDatabaseDAL
    {
        string _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            DataTable table = new DataTable();
            string sql = "SELECT * FROM PersonalDetails ORDER BY FirstName ASC";

            #region try catch

            SqlConnection conn1 = new SqlConnection(_connStr);
            SqlCommand cmd1 = new SqlCommand(sql, conn1);
            SqlDataAdapter ad1 = new SqlDataAdapter(cmd1);
            try
            {
                ad1.Fill(table);
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                ad1.Dispose();
                cmd1.Dispose();
                conn1.Dispose();
            }

            #endregion try catch

            #region Using
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            ad.Fill(table);
                        }
                        catch (Exception ee)
                        {
                            throw;
                        }                        
                    }
                }
            }
            #endregion

            return table;
        }


        public IList<PersonalDetail> LoadData()
        {
            IList<PersonalDetail> list = new List<PersonalDetail>();

            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string sql = "SELECT * FROM PersonalDetails ORDER BY FirstName ASC";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            PersonalDetail pd = new PersonalDetail()
                            {
                                Active = reader.GetBoolean(reader.GetOrdinal("Active")),
                                AutoId = reader.GetInt32(reader.GetOrdinal("AutoId")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Age = reader.GetInt32(reader.GetOrdinal("Age"))
                            };

                            list.Add(pd);
                        }

                    }
                }
            }

            return list;
        }





    }
}
