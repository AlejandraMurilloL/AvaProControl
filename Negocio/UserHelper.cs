using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Negocio
{
    public class UserHelper
    {

        public static byte[] ImageToByteArray(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image ByteToImageArray(byte[] imagen)
        {
            MemoryStream ms = new MemoryStream(imagen);
            Image imagenRetornada = Image.FromStream(ms);
            return imagenRetornada;
        }
    }
}
