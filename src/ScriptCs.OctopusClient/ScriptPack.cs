using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptCs.Contracts;

namespace ScriptCs.OctoClient
{
    public class ScriptPack : IScriptPack
    {
        public void Initialize(IScriptPackSession session)
        {
            //Here you can perform initialization like pass using statements 
            //and references by using the session object's two methods:

            //AddReference
            //Use this method to add library references that need to be 
            //available in your script. After the script pack is loaded, 
            //the specified references will be available for use 
            //without any code inside the script.
            //session.AddReference("System.Net.Http.dll");

            //ImportNamespace
            //This method can import namespaces for use in your scripts to help 
            //keep user's scripts clean and simple.
            session.ImportNamespace("System.Net");
            session.ImportNamespace("Octopus.Client");
            session.ImportNamespace("ScriptCs.Contracts");
            session.ImportNamespace("ScriptCs.OctoClient");
        }

        public IScriptPackContext GetContext()
        {
            return new OctoClientPack();
        }

        public void Terminate()
        {
            // clean up any resources here
        }
    }
}
