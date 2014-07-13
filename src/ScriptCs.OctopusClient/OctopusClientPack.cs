using System.IO;
using System.Runtime.InteropServices.ComTypes;
using Octopus.Client;
using Octopus.Client.Model;
using ScriptCs.Contracts;

namespace ScriptCs.OctopusClient
{
    public class OctopusClientPack : IScriptPackContext
    {
        private IOctopusClient _client;

        public OctopusRepository Initialise(string hostUrl, string apiKey)
        {
            var endpoint = new OctopusServerEndpoint(hostUrl, apiKey);
            var repository = new OctopusRepository(endpoint);
            _client = repository.Client;

            return repository;
        }

        public RootResource GetRootDocument()
        {
            return _client.RootDocument;
        }

        public ResourceCollection<T> List<T>(string path, object pathParameters = null)
        {
            return _client.List<T>(path, pathParameters);
        }

        public T Get<T>(string path, object pathParameters = null)
        {
            return _client.Get<T>(path, pathParameters);
        }

        public Stream GetContent(string path)
        {
            return _client.GetContent(path);
        }
        
        public T Create<T>(string path, T resource)
        {
            return _client.Create(path, resource);
        }

        public void Post(string path)
        {
            _client.Post(path);
        }
        public void Post<T>(string path, T resource)
        {
            _client.Post(path, resource);
        }

        public void Put<T>(string path, T resource)
        {
            _client.Put(path, resource);
        }

        public void PutContent(string path, Stream content)
        {
            _client.PutContent(path, content);
        }

        public T Update<T>(string path, T resource)
        {
            return _client.Update(path, resource);
        }

        public TaskResource Delete(string path)
        {
            return _client.Delete(path);
        }
    }
}
