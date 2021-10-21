using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.WebApi;
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
    public class ProjectsDAL
    {
        //public void DataInsert(GitRepository repo, VssConnection connection)
        //{
        //    try
        //    {
        //        string _connstr = "Data Source=192.168.50.95;Initial Catalog=skashireddy;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        //        using (SqlConnection connection = new SqlConnection(_connstr))
        //        {

        //            var sql = "insert into ReposData(Project,RepoName,DefaultBranch,RepoURL) values(@project,@reponame,@defaultbranch,@repourl)";
        //            using (SqlCommand cmd = new SqlCommand(sql, connection))
        //            {
        //                // @repoid,@CommitId,@CommitteDate,@add,@edit,@delete,@repoid,@email,@name,@comment,@RemoteUrl,@Url
        //                cmd.Parameters.AddWithValue("@project", repo.ProjectReference.Name);
        //                cmd.Parameters.AddWithValue("@reponame", repo.Name);
        //                cmd.Parameters.AddWithValue("@defaultbranch", repo.DefaultBranch);
        //                cmd.Parameters.AddWithValue("@Repourl", repo.Url);
        //                cmd.Parameters.AddWithValue("@projectId", repo.ProjectReference.Id);
        //                cmd.Parameters.AddWithValue("@repoid", repo.Id);


        //                connection.Open();
        //                cmd.ExecuteNonQuery();
        //                connection.Close();

        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw e;
        //    }
        //}
       public void  InsertIntoProjectData(TeamProjectReference reference,int countforrepos,int countforComiits)
        {
            bool istrue;
            istrue = ProjectSp.CheckDatainProject(reference);
            string _conn = ConfigurationManager.ConnectionStrings["CONN"].ConnectionString;

            try
            {
                if (istrue)
                {
                    using (SqlConnection connection = new SqlConnection(_conn))
                    {


                        // var listNumber = commitone.ChangeCounts.Keys.ToList();
                        var sql = "insert into ProjectsDatas(ProjectName,ProjectId,Description,URL,ReposCount) values(@projectname,@PId,@DESP,@Url,@CountRepo)";
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            //projectname,@PId,@DESP,@Url,@CountRepo,@CommitCount
                            // @repoid,@CommitId,@CommitteDate,@add,@edit,@delete,@repoid,@email,@name,@comment,@RemoteUrl,@Url
                            cmd.Parameters.AddWithValue("@projectname", reference.Name);
                            cmd.Parameters.AddWithValue("@PId", reference.Id);
                            cmd.Parameters.AddWithValue("@DESP", reference.Description);
                            cmd.Parameters.AddWithValue("@Url", reference.Url);
                            cmd.Parameters.AddWithValue("@CountRepo", countforrepos);
                            




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
        public void InsertIdentity(GitCommitRef Commit)
        {
            bool istrue;
            istrue = ProjectSp.CheckDatainIdentity(Commit);
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
                        var sql = "insert into Userdata(UserName,Email) values(@Author,@Email)";
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            //projectname,@PId,@DESP,@Url,@CountRepo,@CommitCount
                            // @repoid,@CommitId,@CommitteDate,@add,@edit,@delete,@repoid,@email,@name,@comment,@RemoteUrl,@Url
                           // cmd.Parameters.AddWithValue("@Id", co.Name);
                            cmd.Parameters.AddWithValue("@Author",Commit.Author.Name.ToString());
                            if (Commit.Author.Email == null)
                            {
                                
                                cmd.Parameters.AddWithValue("@Email", DBNull.Value.ToString());
                            }

                            else
                            {
                                cmd.Parameters.AddWithValue("@Email", Commit.Author.Email.ToString());
                            }





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
  
