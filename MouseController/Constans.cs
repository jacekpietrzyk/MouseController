using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseController
{
    public static class Constans
    {
        public static System.IO.DirectoryInfo UserSettings;
        public static System.IO.DirectoryInfo FilesDirectory;
        public static FontFamily myFontFamily;
    }

    public class InitializeConstans
    {
        public InitializeConstans()
        {
            FontLoader fontLoader = new FontLoader();
            Constans.myFontFamily = fontLoader.LoadFont(Properties.Resources.DefaultFont);

            CreateTemporaryFilesDirectory();
            CreateUserDirectory();
        }

        private void CreateTemporaryFilesDirectory()
        {
            Constans.FilesDirectory = new System.IO.DirectoryInfo(Path.Combine(Path.GetTempPath(), Properties.Settings.Default.TempFilesFolderName));

            try
            {
                if (!Directory.Exists(Constans.FilesDirectory.ToString()))
                {
                    Directory.CreateDirectory(Constans.FilesDirectory.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void CreateUserDirectory()
        {
            Constans.UserSettings = new System.IO.DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Properties.Settings.Default.UserSettingFolderName));

            try
            {
                if (!Directory.Exists(Constans.UserSettings.ToString()))
                {
                    Directory.CreateDirectory(Constans.UserSettings.ToString());
                }
            }
            catch (System.IO.IOException IOex)
            {
                MessageBox.Show(IOex.Message.ToString());
            }
            catch (System.UnauthorizedAccessException UAex)
            {
                MessageBox.Show(UAex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }

}
