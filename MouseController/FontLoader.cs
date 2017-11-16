﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseController
{
    class FontLoader
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, int pdv, [In] ref uint pcFonts);

        FontFamily myFontFamily;

        public void LoadFont(byte[] fileFromResources)
        {
            byte[] fontArray = fileFromResources;
            int dataLength = Properties.Resources.DefaultFont.Length;
            try
            {
                IntPtr dataPointer = Marshal.AllocCoTaskMem(dataLength);
                Marshal.Copy(fontArray, 0, dataPointer, dataLength);

                uint cFonts = 0;
                AddFontMemResourceEx(dataPointer, (uint)fontArray.Length, (int)IntPtr.Zero, ref cFonts);
                PrivateFontCollection fontCollection = new PrivateFontCollection();

                fontCollection.AddMemoryFont(dataPointer, dataLength);
                Marshal.FreeCoTaskMem(dataPointer);

                myFontFamily = fontCollection.Families[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem with your custom font allocation");
            }

        }
        public void AllocateFont(Control control, float size)
        {
            control.Font = new Font(myFontFamily, size);
        }

        public void AllocateFont(ToolStripLabel control, float size)
        {
            control.Font = new Font(myFontFamily, size);
        }
    }
}
