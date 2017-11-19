using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseController
{
    class JsonWorkProfileSerialization
    {

        public void Serialize(WorkProfile profile)
        {
            
            string result = JsonConvert.SerializeObject(profile, Formatting.Indented);
            
            File.WriteAllText(Constans.UserSettings.ToString() + @"/fileJson.json", result);
        }

        public WorkProfile Deserialize()
        {
            return new WorkProfile();
        }
    }
}
