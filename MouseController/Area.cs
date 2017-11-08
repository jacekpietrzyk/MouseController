using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseController
{
    public class Area
    {
        public string Name { get; set; }
        public int StartPositionX { get; set; }
        public int StartPositionY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string FileName { get; set; }
        public Bitmap Bitmap { get; set; }
        public int ClickX
        {
            get
            {
                return StartPositionX + Width / 2;
            }

        }
        public int ClickY
        {
            get
            {
                return StartPositionY + Height / 2;
            }

        }
    }
}
