using Microsoft.TeamFoundation.SourceControl.WebApi;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppAzureDevops.DAL
{
    public class CommitsDal
    {
        public void DataInsert(GitCommitRef commitone, GitRepository repo)
        {
            try
            {
                string _connstr = "Data Source=192.168.50.95;Initial Catalog=skashireddy;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
                using (SqlConnection connection = new SqlConnection(_connstr))
                {
                    //string CommentInsert = commitone.Comment;
                    //var sql = "insert into CommitsData(CommitId,RepoId,Comments)values('Com,1,@CommentInsert)";
                    bool isexist = CheckinCommittable(commitone, repo);
                    if (isexist)
                    {
                        var listNumber = commitone.ChangeCounts.Keys.ToList();
                        var sql = "insert into CommitsData(RepoId,CommitId,CommitDate,Adds,Deletes,Edits,UserId,Email,Comments,RemoteUrl,Url) values(@repoid,@CommitId,@CommitteDate,@add,@edit,@delete,@repoid,@email,@comment,@RemoteUrl,@Url)";
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            // @repoid,@CommitId,@CommitteDate,@add,@edit,@delete,@repoid,@email,@name,@comment,@RemoteUrl,@Url
                            cmd.Parameters.AddWithValue("@comment", commitone.Comment);
                            cmd.Parameters.AddWithValue("@repoid", repo.Id);
                            cmd.Parameters.AddWithValue("@CommitId", commitone.CommitId);
                            cmd.Parameters.AddWithValue("@CommitteDate", commitone.Committer.Date);
                            cmd.Parameters.AddWithValue("@add", listNumber[0]);
                            cmd.Parameters.AddWithValue("@edit", listNumber[1]);
                            cmd.Parameters.AddWithValue("@delete", listNumber[2]);
                            if (commitone.Committer.Email != null)
                            {
                                cmd.Parameters.AddWithValue("@email", commitone.Committer.Email);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@email",DBNull.Value.ToString());
                            }
         
                            cmd.Parameters.AddWithValue("@RemoteUrl", commitone.RemoteUrl);
                            cmd.Parameters.AddWithValue("@Url", commitone.Url);


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

        private bool CheckinCommittable(GitCommitRef commitone, GitRepository repo)
        {
            string _conn = ConfigurationManager.ConnectionStrings["CONN"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(_conn))
            {
                var sql = "CheckCommitdata";



                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlParameter[] parms = new SqlParameter[2];
                    parms[0] = new SqlParameter("@id", SqlDbType.NVarChar);

                    parms[0].Value = repo.Id.ToString();
                    parms[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                    parms[1].Value = commitone.CommitId.ToString();
                    IDbDataParameter ispresent = cmd.CreateParameter();
                    cmd.Parameters.Add(ispresent);

                    cmd.Parameters.AddRange(parms);


                    //connection.Open();
                    // isreturn=cmd.ExecuteNonQuery();
                    ispresent.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    int returnVALUE = (int)(ispresent.Value);
                    connection.Close();

                    //cmd.Parameters["@IsPresent"].Direction = ParameterDirection.Output;


                    if (returnVALUE == 0)
                    {
                        return true;
                    }
                    return false;
                    //return returnVALUE;
                }
            }
        }
    }
}
