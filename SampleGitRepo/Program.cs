using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using SampleConsoleAppAzureDevops.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleConsoleAppAzureDevops
{
    class Program
    {
        public static void Main(string[] args)
        {
            Uri orgUrl = new Uri("https://tpdevops.tollplus.com/P11-M50");    // Organization URL, for example: https://dev.azure.com/fabrikam               
            String personalAccessToken = "jgbcygmnqwc5ji63pd5jjmho6gs7caylzacafa2fbsu2x2hjhpva";  // See https://docs.microsoft.com/azure/devops/integrate/get-started/authentication/pats
              // ID of a work item, for example: 12

            // Create a connection
            VssConnection connection = new VssConnection(orgUrl, new VssBasicCredential(string.Empty, personalAccessToken));
           // public vCommitReal = connection.GetClient<GitHttpClient>();
            // Show details a work item
            ListPullRequestsForProject(connection);
            //InsertIntoDataBase(connection);
        }

        public static void InsertCIntoDataBase(VssConnection connection, GitCommitRef CommitReal,GitRepository Repo)
        {
            CommitsDal RP = new CommitsDal();
            RP.DataInsert(CommitReal,Repo);
        }

        public static void InsertRIntoDataBase(VssConnection connection, GitRepository Repo)
        {
            ProjectsDAL RD = new ProjectsDAL();
            //RD.DataInsert(Repo);
        }

        public static IEnumerable<GitPullRequest> ListPullRequestsForProject(VssConnection connection)
        {
            GitHttpClient gitClient = connection.GetClient<GitHttpClient>();
            var project=  FindAnyProject(connection);
            List<GitRepository> repos = gitClient.GetRepositoriesAsync(project.Id).Result;
            List<GitPullRequest> prs = new List<GitPullRequest>();
            List<GitPullRequest> Review = new List<GitPullRequest>();

            foreach (var repo in repos)
            {

                var prsrepo =gitClient.GetPullRequestsAsync(project.Id, repo.Id, new GitPullRequestSearchCriteria() {Status=PullRequestStatus.All },top:500000).Result;
                prsrepo = prsrepo.OrderBy(x => x.PullRequestId).ToList();
                
                // pullrequestid,reviewer,Desp, getpullreqworkitems,pull request id=3,tittle,
                //prsrepo = prsrepo.Where(x => x.PullRequestId > 3000);
                var commits=connection.GetClient<GitHttpClient>().GetCommitsAsync(repo.Id, new GitQueryCommitsCriteria() { FromDate= "6 / 14 / 2008 12:00:00", ShowOldestCommitsFirst=true,Top=500000}).Result;
                
                Console.WriteLine("project {0}", project.Name);
                foreach (GitPullRequest pr in prsrepo)
                {
                    Console.WriteLine("{0} #{1} {2} -> {3}",
                        pr.Title.Substring(0, Math.Min(40, pr.Title.Length)),
                        pr.PullRequestId,
                        pr.SourceRefName,
                        pr.TargetRefName);
                    
                   PullrequestDal.InsertintoPullrequest(pr, repo.Id.ToString(), project.Id.ToString());
                   // var prsworkitems = gitClient.GetPullRequestWorkItemRefsAsync(repo.Id, pr.PullRequestId, new GitQueryCommitsCriteria() { FromDate = "6 / 14 / 2008 12:00:00", ShowOldestCommitsFirst = true, Top = 500000 }).Result;




                }
                prs.AddRange(prsrepo);


                foreach (var commit in commits)
                {
                    int CountforRepos = repos.Count;
                    int CountforCommits = commits.Count;
                    ProjectsDAL RP = new ProjectsDAL();
                    RP.InsertIdentity(commit);
                    RP.InsertIntoProjectData(project, CountforRepos,CountforCommits);
                    var changes = connection.GetClient<GitHttpClient>().GetChangesAsync(commit.CommitId, repo.Id).Result;
                   
                    ReposDal RD = new ReposDal();
                    //Commit id,repoid,objectid,url,Changetype,path,
                    RD.InsertRepos(repo,CountforCommits);
                    InsertCIntoDataBase(connection,commit,repo);

                    foreach (var Change in changes.Changes)
                    {
                        ChangesDal.InsertinChange(Change,commit.CommitId.ToString(),repo.Id.ToString());
                    }
                    //ChangesDal.InsertinChange(changes);

                }
                var branches = connection.GetClient<GitHttpClient>().GetBranchesAsync(project.Id, repo.Id).Result;
                
            }

            return prs;
        }

        public static TeamProjectReference FindAnyProject(VssConnection connection)
        {
            TeamProjectReference project;
            if (!FindAnyProject(connection,out project))
            {
                throw new Exception("No sample projects available. Create a project in this collection and run the sample again.");
            }

            return project;
        }

        public static bool FindAnyProject(VssConnection connection, out TeamProjectReference project)
        {
            // Check if we already have a default project loaded
            ProjectHttpClient projectClient = connection.GetClient<ProjectHttpClient>();
            project = projectClient.GetProjects(null, top: 10).Result.Last();
            return project != null;
        }
    }
}
//Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = model; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False