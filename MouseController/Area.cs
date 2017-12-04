using System.Drawing;
using Newtonsoft.Json;
using System.IO;
using System;

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
        private string BitmapByteArray
        {
            get
            {
                ImageConverter converter = new ImageConverter();
                return Convert.ToBase64String((byte[])converter.ConvertTo(this.Bitmap, typeof(byte[])));
            }
            set
            {
                var bytes = Convert.FromBase64String(value);
                using (var ms = new MemoryStream(bytes))
                {
                    this.Bitmap = new Bitmap(Bitmap.FromStream(ms));
                }
            }
        }
        
        public string ActivityName { get; set; } = String.Empty;
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

        public Area Clone()
        {
            return new Area
            {
                Name = this.Name,
                StartPositionX = this.StartPositionX,
                StartPositionY = this.StartPositionY,
                Width = this.Width,
                Height = this.Height,
                FileName = this.FileName,
                ActivityName = this.ActivityName,
                Bitmap = (Bitmap)this.Bitmap.Clone()
            };
        }
    }
}
