var octopus = Require<OctopusClientPack>();
var server = octopus.Server("http://server/octopusdeploy/api", "API-XXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("Getting the current user...");
var user = server.Users.GetCurrent();
Console.WriteLine("Current user: {0}", user.DisplayName);
Console.WriteLine("Getting your dashboard...");
var dashboard = server.Dashboards.GetDashboard();
foreach(var item in dashboard.Items)
{
  var project = server.Projects.Get(item.ProjectId);
  var environment = server.Environments.Get(item.EnvironmentId);
  Console.WriteLine("Project: {0} -> Environment: {1} -> Release Version: {2}", project.Name, environment.Name, item.ReleaseVersion);
}
