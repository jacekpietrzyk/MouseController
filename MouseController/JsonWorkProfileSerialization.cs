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
            try
            {
                string result = JsonConvert.SerializeObject(profile, Formatting.Indented,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects, TypeNameHandling = TypeNameHandling.Objects });
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serialization failded: " + ex.Message);
                return null;
            }
        }
        public void SaveJson(string result)
        {
            using (SaveFileDialog saveJsonDialog = new SaveFileDialog())
            {
                saveJsonDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                saveJsonDialog.Title = "Save Work Profile";
                saveJsonDialog.InitialDirectory = Constans.UserSettings.ToString();
                saveJsonDialog.FileName = "myProfile.json";

                if (saveJsonDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writing = new StreamWriter(saveJsonDialog.FileName);
                    try
                    {
                        writing.Write(result);
                        writing.Close();
                        MessageBox.Show("Serialization succesfully finished.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Saving json file failed: " + ex.Message);
                    }
                }
            }
        }
        public WorkProfile DeserializeProfile()
        {
            try
            {
                string jsonText = this.OpenJson();
                if (jsonText != null)
                {
                    WorkProfile deserializedProfile = JsonConvert.DeserializeObject<WorkProfile>(jsonText,
                                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects, TypeNameHandling = TypeNameHandling.Objects });
                    MessageBox.Show("Deserialization successfully finished");
                    return deserializedProfile;
                }
                else return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deserialization failed: " + ex.Message);
                return null;
            }
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
