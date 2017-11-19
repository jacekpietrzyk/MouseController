using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseController
{
    class JsonWorkProfileSerialization
    {

        public string SerializeProfile(WorkProfile profile)
        {
            
            string result = JsonConvert.SerializeObject(profile, Formatting.Indented,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            return result;
        }

        public void SaveJson(string result)
        {
            using (SaveFileDialog saveJsonDialog = new SaveFileDialog())
            {
                saveJsonDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                saveJsonDialog.Title = "Save Work Profile";
                saveJsonDialog.InitialDirectory = Constans.UserSettings.ToString();
                saveJsonDialog.FileName = "myProfile.json";

                if(saveJsonDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writing = new StreamWriter(saveJsonDialog.FileName);
                    writing.Write(result);
                    writing.Close();
                    MessageBox.Show("The profile has been saved");
                }
            }
        }

        public WorkProfile DeserializeProfile()
        {
            WorkProfile deserializedProfile = JsonConvert.DeserializeObject<WorkProfile>(this.OpenJson(),
                                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            return deserializedProfile;
        }
        public string OpenJson()
        {
            using (OpenFileDialog openJsonFile = new OpenFileDialog())
            {
                openJsonFile.InitialDirectory = Constans.UserSettings.ToString();
                openJsonFile.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                if (openJsonFile.ShowDialog() == DialogResult.OK)
                {
                    if (openJsonFile.FileName.Trim() != string.Empty)
                    {
                        using (StreamReader r = new StreamReader(openJsonFile.FileName))
                        {
                            string json = r.ReadToEnd();
                            return json;
                        }
                    }
                    else return null;
                }
                else return null;
            }
        }
        
    }
}
