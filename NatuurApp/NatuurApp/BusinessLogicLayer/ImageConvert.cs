using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace NatuurApp.BusinessLogicLayer
{
   public static class ImageConvert
    {
        public static ImageSource ByteToImage(byte[] imageData)
        {
            BitmapImage biImg = new BitmapImage();
            MemoryStream ms = new MemoryStream(imageData);
            biImg.SetSource(ms);
            ImageSource imgSrc = biImg as ImageSource;
            return imgSrc;
        }
    }
}
