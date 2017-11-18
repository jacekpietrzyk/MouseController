using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseController
{
    class JsonWorkProfileSerialization
    {

        public string Serialize(WorkProfile profile)
        {
            
            string result = JsonConvert.SerializeObject(profile, Formatting.Indented);
            return result;
        }

        public WorkProfile Deserialize()
        {
            return new WorkProfile();
        }
    }
}
