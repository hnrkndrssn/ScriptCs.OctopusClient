var octopus = Require<OctopusClientPack>();
var repo = octopus.Initialise("http://server/octopusdeploy/api", "API-XXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("Getting the current user...");
var user = repo.Users.GetCurrent();
Console.WriteLine("Current user: {0}", user.DisplayName);
Console.WriteLine("Getting your dashboard...");
var dashboard = repo.Dashboards.GetDashboard();
foreach(var item in dashboard.Items)
{
  var project = repo.Projects.Get(item.ProjectId);
  var environment = repo.Environments.Get(item.EnvironmentId);
  Console.WriteLine("Project: {0} -> Environment: {1} -> Release Version: {2}", project.Name, environment.Name, item.ReleaseVersion);
}
