ScriptCs.OctoClient
===================

## About
This is an Octopus Client [Script Pack](https://github.com/scriptcs/scriptcs/wiki) for [scriptcs](https://github.com/scriptcs/scriptcs) that can be used to interact with an Octopus Deploy server using the Octopus API.

## Installation
Install the NuGet package by running `scriptcs -install ScriptCs.OctopusClient`

## Usage

``` csharp
var octopus = Require<OctopusClientPack>();
var repo = octopus.GetRepository("http://server/octopusdeploy/api", "API-XXXXXXXXXXXXXXXXXXXXXXXXXXX");
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
```

## License

The MIT License (MIT)

Copyright (c) 2014 Henrik Andersson

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
