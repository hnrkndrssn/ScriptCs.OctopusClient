using Octopus.Client;
using ScriptCs.Contracts;

namespace ScriptCs.OctopusClient
{
    public class OctopusClientPack : IScriptPackContext
    {
        public OctopusRepository GetRepository(string hostUrl, string apiKey)
        {
            var endpoint = new OctopusServerEndpoint(hostUrl, apiKey);
            
            return new OctopusRepository(endpoint);
        }
    }
}
