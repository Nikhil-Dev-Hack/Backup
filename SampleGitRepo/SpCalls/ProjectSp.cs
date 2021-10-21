using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppAzureDevops.SpCalls
{
    public class ProjectSp
    {
        public static bool CheckDatainIdentity(GitCommitRef commit)
        {
            bool isreturn;
            string _conn = ConfigurationManager.ConnectionStrings["CONN"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(_conn))
            {
                var sql = "CheckIdentityData";
                Random r = new Random();
                var count = r.Next(10000);


                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {



                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlParameter[] parms = new SqlParameter[2];
                    parms[0] = new SqlParameter("@id", SqlDbType.NVarChar);

                    parms[0].Value = commit.Author.Name.ToString();
                    parms[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                    if (commit.Author.Email == null)
                    {
                        //string Nomail = string.Concat("Nogmail", count, "@tollplus.com");
                        parms[1].Value = DBNull.Value.ToString();
                    }

                    else
                    {
                        parms[1].Value = commit.Author.Email.ToString();
                    }
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
        public static bool CheckDatainProject(TeamProjectReference reference)
        {
            bool isreturn;
            string _conn = ConfigurationManager.ConnectionStrings["CONN"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(_conn))
            {
                var sql = "CheckDataProject";



                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlParameter[] parms = new SqlParameter[2];
                    parms[0] = new SqlParameter("@id", SqlDbType.NVarChar);

                    parms[0].Value = reference.Id.ToString();
                    parms[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                    parms[1].Value = reference.Name.ToString();
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

        public static bool CheckDatainRepos(GitRepository Repo)
        {
            bool isreturn;
            string _conn = ConfigurationManager.ConnectionStrings["CONN"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(_conn))
            {
                var sql = "CheckRepoData";
                Random r = new Random();
                var count = r.Next(10000);


                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {



                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlParameter[] parms = new SqlParameter[2];
                    parms[0] = new SqlParameter("@id", SqlDbType.NVarChar);

                    parms[0].Value = Repo.Id.ToString();
                    parms[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                    parms[1].Value = Repo.ProjectReference.Id.ToString();
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

        public static bool CheckDatainPullRequest(GitPullRequest commit, string repoid)
        {
            bool isreturn;
            string _conn = ConfigurationManager.ConnectionStrings["CONN"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(_conn))
            {
                var sql = "CheckPullrequestdata";
                Random r = new Random();
                var count = r.Next(10000);


                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {



                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlParameter[] parms = new SqlParameter[2];
                    parms[0] = new SqlParameter("@id", SqlDbType.Int);

                    parms[0].Value = commit.PullRequestId;
                    parms[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                    parms[1].Value = repoid;

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
        public static bool CheckDatainChanges(GitChange Changes, string commmitid)
        {
            bool isreturn;
            string _conn = ConfigurationManager.ConnectionStrings["CONN"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(_conn))
            {
                var sql = "CheckChangeData";
                Random r = new Random();
                var count = r.Next(10000);


                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {



                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlParameter[] parms = new SqlParameter[2];
                    parms[0] = new SqlParameter("@id", SqlDbType.NVarChar);

                    parms[0].Value = commmitid;
                    parms[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                    parms[1].Value = Changes.Item.ObjectId.ToString();

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
