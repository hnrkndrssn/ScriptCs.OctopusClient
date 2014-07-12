using System.Net;
using ScriptCs.Contracts;
using Octopus.Client;

namespace ScriptCs.OctoClient
{
    public class OctoClientPack : IScriptPackContext
    {
        public OctopusRepository GetRepository(string hostUrl, string apiKey)
        {
            var endpoint = new OctopusServerEndpoint(hostUrl, apiKey);
            
            return new OctopusRepository(endpoint);
        }
    }
}
