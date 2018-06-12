
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Web.Http.Dispatcher;

namespace TestInterface.Resolver
{
    public class DynamicAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);
            string localPath = @"C:\Users\Taras_Kobernyk\Documents\visual studio 2012\Projects\TestInterface\AddionalController\bin\Debug";
            Assembly onTheFly = Assembly.LoadFrom(Path.Combine(localPath, "AddionalController.dll"));
            assemblies.Add(onTheFly);
            return assemblies;
        }
    }
}