using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Configuration
{
    public class ClassConfigSetting
    {
        /*To get the values in the json file we created this class which will hold all the properties of the confifsetting.json
          which will define in the configuration file.  */
        public string BrowserType { get; set; }
        public string LogLevel { get; set; }
    }
}
