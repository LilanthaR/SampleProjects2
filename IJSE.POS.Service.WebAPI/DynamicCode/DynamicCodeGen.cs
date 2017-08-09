using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Reflection;
using System.CodeDom.Compiler;
using System.Text;


namespace IJSE.POS.Service.WebAPI.DynamicCode
{
    public class DynamicCodeGen
    {
        string _controllerName;

        public DynamicCodeGen(string controllerName)
        {
            _controllerName = controllerName.Replace(" ", string.Empty);
        }

        public Assembly CreateDll()
        {
            //IDictionary<string, string> compParams =
            //     new Dictionary<string, string>() { { "CompilerVersion", "v4.5" } };
            //CodeDomProvider codeProvider = CodeDomProvider.CreateProvider("CSharp", compParams);

           // Dictionary<string, string> provOptions = new Dictionary<string, string>();
           // provOptions.Add("CompilerVersion", "v4");
            // Get the provider for Microsoft.CSharp
            //CodeDomProvider codeProvider = CodeDomProvider.CreateProvider("CSharp", provOptions);
            CodeDomProvider codeProvider = CodeDomProvider.CreateProvider("CSharp");

            string outputDll = _controllerName + ".dll";

            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = false;
            parameters.OutputAssembly = outputDll;
            parameters.ReferencedAssemblies.Add(@"System.Net.Http.dll");
            parameters.ReferencedAssemblies.Add(@"System.Net.Http.WebRequest.dll");
            parameters.ReferencedAssemblies.Add(@"System.Net.Http.Formatting.dll");
            parameters.ReferencedAssemblies.Add(@"System.Web.Http.dll");
            string code = new StringBuilder()
                .AppendLine("using System.Web.Http;")
                .AppendLine("using System;")
                .AppendLine("using System.Collections.Generic;")
                .AppendLine("namespace IJSE.POS.Service.WebAPI")
                .AppendLine("{")
                .AppendLine(string.Format("public class {0} : ApiController", _controllerName))
                .AppendLine(" {")
                .AppendLine("  public string Get()")
                .AppendLine("  {")
                .AppendLine(string.Format("return \"Hi from a Dynamic controller library- {0} !\";", _controllerName))
                .AppendLine("  }")
                .AppendLine(" }")
                .AppendLine("}")
                .ToString();
            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, code);
            if (results.Errors.Count > 0)
            {
                Console.WriteLine("Build Failed");
                foreach (CompilerError CompErr in results.Errors)
                {
                    Console.WriteLine(
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Build Succeeded");
                return Assembly.LoadFrom(outputDll);
            }
            return null;
        }
    }
}