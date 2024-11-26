using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CRM.Application
{
    public class ControlArchivo
    {
        Data.ControlArchivo _ControlArchivo = new Data.ControlArchivo();
        public Models.ProductoImagen NuevaImagen(HttpPostedFile Archivo, string DirectorioUsuario)
        {
            Models.ProductoImagen _ProductoImagen = new Models.ProductoImagen();
            String FileExtension = Path.GetExtension(Archivo.FileName).ToLower();

            if (!Directory.Exists(DirectorioUsuario))
            {
                Directory.CreateDirectory(DirectorioUsuario);
            }

            if (".jpg".Contains(FileExtension) ^ ".png".Contains(FileExtension) ^ ".jpeg".Contains(FileExtension))
            {
                Models.ControlArchivo archivo = _ControlArchivo.NuevoArchivo();
                string NombreArchivo = archivo.Clave + archivo.Id.ToString().PadLeft(12, '0');

                Image image = ResizeImage(Image.FromStream(Archivo.InputStream, true, true), 900, 600);
                image.Save(DirectorioUsuario + NombreArchivo + ".png");
                _ProductoImagen.NmArchivo = NombreArchivo + ".png";
                _ProductoImagen.NmOriginal = Archivo.FileName;
            }

            return _ProductoImagen;
        }

        public static Image ResizeImage(Image srcImage, int newWidth, int newHeight)
        {
            using (Bitmap imagenBitmap = new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
            {
                imagenBitmap.MakeTransparent();
                imagenBitmap.SetResolution(
                   Convert.ToInt32(srcImage.HorizontalResolution),
                   Convert.ToInt32(srcImage.HorizontalResolution));

                using (Graphics imagenGraphics = Graphics.FromImage(imagenBitmap))
                {
                    imagenGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                    imagenGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    imagenGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    imagenGraphics.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(0, 0, srcImage.Width, srcImage.Height), GraphicsUnit.Pixel);

                    MemoryStream imagenMemoryStream = new MemoryStream();
                    imagenBitmap.MakeTransparent();
                    imagenBitmap.Save(imagenMemoryStream, ImageFormat.Png);
                    srcImage = Image.FromStream(imagenMemoryStream);
                }
            }
            return srcImage;
        }

        public Models.Archivo NuevoArchivo(HttpPostedFile Archivo, string DirectorioUsuario)
        {
            Models.Archivo _Archivo = new Models.Archivo();
            String FileExtension = Path.GetExtension(Archivo.FileName).ToLower();

            if (!Directory.Exists(DirectorioUsuario))
            {
                Directory.CreateDirectory(DirectorioUsuario);
            }

            Models.ControlArchivo NuevoArchivo = _ControlArchivo.NuevoArchivo();
            string NombreArchivo = NuevoArchivo.Clave + NuevoArchivo.Id.ToString().PadLeft(12, '0');
            Archivo.SaveAs(DirectorioUsuario + NombreArchivo + FileExtension);
            _Archivo.NombreNuevo = NombreArchivo + FileExtension;
            _Archivo.NombreOrigianl = Archivo.FileName;
            _Archivo.Extencion = FileExtension;
            return _Archivo;
        }
    }
}
