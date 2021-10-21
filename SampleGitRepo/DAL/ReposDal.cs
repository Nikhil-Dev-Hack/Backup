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
   public  class ReposDal
    {
        public void InsertRepos(GitRepository Repo,int CountCommits)
        {
            bool istrue=false;
            istrue = ProjectSp.CheckDatainRepos(Repo);
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
                       var sql = "insert into ReposDataOriginal(RepoName,RepoId,RepoURL,DefaultBranch,ProjectName,ProjectId,CommitCount) values(@RepoName,@Id,@URL,@Branch,@PName,@PId,@Countcommit)";
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            //RepoName,@Id,@URL,@Branch,@PName,@PId
                            cmd.Parameters.AddWithValue("@RepoName",Repo.Name);
                            cmd.Parameters.AddWithValue("@Id", Repo.Id);
                            cmd.Parameters.AddWithValue("@URL", Repo.Url);
                            cmd.Parameters.AddWithValue("@Branch", Repo.DefaultBranch);
                            cmd.Parameters.AddWithValue("@PName", Repo.ProjectReference.Name);
                            cmd.Parameters.AddWithValue("@PId", Repo.ProjectReference.Id);
                            cmd.Parameters.AddWithValue("@Countcommit", CountCommits);
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
