using Microsoft.TeamFoundation.SourceControl.WebApi;
using SampleConsoleAppAzureDevops.SpCalls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppAzureDevops.DAL
{
    public class ChangesDal
    {
        public static void InsertinChange(GitChange Changes,string Commitid,string Repoid)
        {
            bool istrue;
            istrue = ProjectSp.CheckDatainChanges(Changes,Commitid);
            string _conn = ConfigurationManager.ConnectionStrings["CONN"].ConnectionString;
            Random r = new Random();
            var count = r.Next(10000);

            try
            {
                if (istrue)
                {
                    using (SqlConnection connection = new SqlConnection(_conn))
                    {

                        // var listNumber = commitone.ChangeCounts.Keys.ToList();
                        var sql = "insert into ChangesData(CommitId,RepoId,ObjectId,Url,Path,Chnagetype) values(@CommitId,@RepoId,@ObjectId,@Url,@Path,@Chnagetype)";
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            //CommitId,@RepoId,@ObjectId,@Url,@Path,@Chnagetype
                            // cmd.Parameters.AddWithValue("@Id", co.Name);
                            //cmd.Parameters.AddWithValue("@Author", Commit.Author.Name.ToString());
                            cmd.Parameters.AddWithValue("@CommitId",Commitid);
                            cmd.Parameters.AddWithValue("@RepoId",Repoid);
                            cmd.Parameters.AddWithValue("@ObjectId",Changes.Item.ObjectId.ToString());
                            cmd.Parameters.AddWithValue("@Url",Changes.Item.Url.ToString());
                            cmd.Parameters.AddWithValue("@Path",Changes.Item.Path.ToString());
                            cmd.Parameters.AddWithValue("@Chnagetype",Changes.ChangeType.ToString());

                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }

        }
    }
}
   