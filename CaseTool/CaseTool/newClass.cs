using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTool
{
    class newClass
    {
        public string name = "";
        public List<string> vars = new List<string>();
        public List<string> methods = new List<string>();


        // overide tostring
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void addVar(string var)
        {
            vars.Add(var);
        }

        public List<string> getVars(string var)
        {
            return vars;
        }

        public void addMethod(string method)
        {
            methods.Add(method);
        }

        public List<string> getMethods(string var)
        {
            return methods;
        }

        public string getAll()
        {
            string result = name + "\n";
            result = result + "Vars: \n";
            foreach (string a in vars)
            {
                result = result + a + "\n";
            }
            result = result + "Methods: \n";
            foreach (string a in methods)
            {
                result = result + a + "\n";
            }
            return result;
        }

        public string generateCode()
        {
            string codebase = "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Text;\nusing System.Threading.Tasks;\n\n";

            string codeNameSpace = "namespace test\n{\n";

            string codeClass = "    class " + name + " {\n";

            foreach (string a in vars)
            {
                codeClass = codeClass + a + "\n";
            }

            foreach (string a in methods)
            {
                codeClass = codeClass + a + "\n";
            }

            codeClass = codeClass + "}\n}";
            return codebase+codeNameSpace+codeClass;
        }
    }
}
