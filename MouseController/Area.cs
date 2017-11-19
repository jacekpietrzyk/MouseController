using System.Drawing;
using Newtonsoft.Json;
using System.IO;

namespace MouseController
{
    [JsonObject(IsReference = true)]
    public class Area
    {
        public string Name { get; set; }

        public int StartPositionX { get; set; }
        public int StartPositionY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public string FileName { get; set; }
        [JsonIgnore]
        public Bitmap Bitmap { get; set; }
        [JsonProperty]
        private byte[] BitmapByteArray
        {
            get
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(Bitmap, typeof(byte[]));
            }
        }

        //public static byte[] ConvertToBytes(BitmapImage bitmapImage)
        //{
        //    using (var ms = new MemoryStream())
        //    {
        //        var btmMap = new WriteableBitmap
        //            (bitmapImage.PixelWidth, bitmapImage.PixelHeight);

        //        // write an image into the stream
        //        btmMap.SaveJpeg(ms, bitmapImage.PixelWidth, bitmapImage.PixelHeight, 0, 100);

        //        return ms.ToArray();
        //    }
        //}

        public string ActivityName { get; set; }
        [JsonIgnore]
        public int ClickX
        {
            get
            {
                return StartPositionX + Width / 2;
            }

        }
        [JsonIgnore]
        public int ClickY
        {
            get
            {
                return StartPositionY + Height / 2;
            }

        }
    }
}
