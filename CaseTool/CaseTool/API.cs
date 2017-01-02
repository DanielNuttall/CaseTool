using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseTool
{
    class API
    {
        public string status
        {
            get; set;
        }
        public string limit
        {
            get; set;
        }

        public List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
    }
}
