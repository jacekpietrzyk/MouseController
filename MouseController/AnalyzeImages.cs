using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace MouseController
{
	public class AnalyzeImages
	{
        

        public enum CompareResult
		{
			ciCompareOk,
			ciPixelMismatch,
			ciSizeMismatch
		};

		public CompareResult Compare(Bitmap bmp1, Bitmap bmp2)
		{
			CompareResult cr = CompareResult.ciCompareOk;

			//Test to see if we have the same size of image
			if (bmp1.Size != bmp2.Size)
			{
				cr = CompareResult.ciSizeMismatch;
			}
			else
			{
				//Convert each image to a byte array
				System.Drawing.ImageConverter ic = new System.Drawing.ImageConverter();
				byte[] btImage1 = new byte[1];
				btImage1 = (byte[])ic.ConvertTo(bmp1, btImage1.GetType());
				byte[] btImage2 = new byte[1];
				btImage2 = (byte[])ic.ConvertTo(bmp2, btImage2.GetType());
				
				//Compute a hash for each image
				SHA256Managed shaM = new SHA256Managed();
				byte[] hash1 = shaM.ComputeHash(btImage1);
				byte[] hash2 = shaM.ComputeHash(btImage2);

				//Compare the hash values
				for (int i = 0; i < hash1.Length && i < hash2.Length && cr == CompareResult.ciCompareOk; i++)
				{
					if (hash1[i] != hash2[i])
						cr = CompareResult.ciPixelMismatch;
				}
			}
			return cr;
		}

        public Bitmap MakeScreenShot(Area area)
        {
            using (Bitmap bmp = new Bitmap(area.Width, area.Height))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(area.StartPositionX, area.StartPositionY, 0, 0, bmp.Size);
                }

                Rectangle cloneRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                area.Bitmap = bmp.Clone(cloneRect, bmp.PixelFormat);

                return area.Bitmap;
            }
        }

        public string SaveBitmap(Area area)
        {
            area.FileName = System.IO.Path.Combine(Constans.FilesDirectory.ToString(), String.Format("{0}area.bmp", new Random().Next()));
            area.Bitmap.Save(area.FileName, ImageFormat.Bmp);
            return area.FileName;
        }
    

        public bool AreaNotEmpty(Area area)
        {
            if (area.Width != 0 && area.Height != 0)
            {
                return true;
            }
            else return false;
        }

    }
    

    
}
