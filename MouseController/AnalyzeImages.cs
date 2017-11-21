using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MouseController
{
	public class AnalyzeImages
	{
		public enum CompareResult
		{
			CompareOK,
			ComparedAndDifferent,
			ComparedAndDiffrentSizes
		};

		public CompareResult Compare(Bitmap bmp1, Bitmap bmp2)
		{
			CompareResult cr = CompareResult.CompareOK;

			//Test to see if we have the same size of image
			if (bmp1.Size != bmp2.Size)
			{
				cr = CompareResult.ComparedAndDiffrentSizes;
			}
			else
			{
				try
				{
					//Convert to a byte array
					System.Drawing.ImageConverter imageConverter = new System.Drawing.ImageConverter();
					byte[] bitArray1 = new byte[1];
					bitArray1 = (byte[])imageConverter.ConvertTo(bmp1, bitArray1.GetType());

					byte[] bitArray2 = new byte[1];
					bitArray2 = (byte[])imageConverter.ConvertTo(bmp2, bitArray2.GetType());

					//Compute a hash for each image
					SHA256Managed SHAManager = new SHA256Managed();
					byte[] hash1 = SHAManager.ComputeHash(bitArray1);
					byte[] hash2 = SHAManager.ComputeHash(bitArray2);

					//Compare the hash values
					for (int i = 0; i < hash1.Length && i < hash2.Length && cr == CompareResult.CompareOK; i++)
					{
						if (hash1[i] != hash2[i])
							cr = CompareResult.ComparedAndDifferent;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Exception occurred");
				}

			}
			return cr;
		}

		public Bitmap MakeScreenShot(Area area)
		{
			using (Bitmap bmp = new Bitmap(area.Width, area.Height))
			{
				try
				{
					using (Graphics g = Graphics.FromImage(bmp))
					{
						g.CopyFromScreen(area.StartPositionX, area.StartPositionY, 0, 0, bmp.Size);
					}

					Rectangle cloneRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
					area.Bitmap = bmp.Clone(cloneRect, bmp.PixelFormat);

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Exception occurred");
				}
				return area.Bitmap;
			}
		}

		public string SaveBitmap(Area area)
		{
			try
			{
				area.FileName = System.IO.Path.Combine(Constans.FilesDirectory.ToString(), String.Format("{0}area.bmp", new Random().Next()));
				area.Bitmap.Save(area.FileName, ImageFormat.Bmp);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Exception occurred");
			}
			return area.FileName;
		}
	
		public bool AreaNotEmpty(Area area)
		{
			if (area.Width != 0 && area.Height != 0 && area.Name != "")
			{
				return true;
			}
			else return false;
		}

        public bool CompareAreas(Area conditionalArea, Area compareArea)
        {
            MakeScreenShot(compareArea);
            if (Compare(conditionalArea.Bitmap, compareArea.Bitmap) == 0)
            {
                //resultLabel.Text = String.Format("Result: {0} task completed", resultCounter + 1);

                return true;
            }
            else
            {
                return false;
            }
        }


    }



}
