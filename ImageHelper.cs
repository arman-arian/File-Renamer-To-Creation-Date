using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace FileRenamerToCreationDate
{
    public static class ImageHelper
    {
        private static readonly Regex Regex = new Regex(":");
        private static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };

        public static DateTime? GetDateTakenFromImage(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var myImage = Image.FromStream(fs, false, false))
                {
                    var propItem = myImage.GetPropertyItem(36867);
                    var dateTaken = Regex.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    return DateTime.Parse(dateTaken);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public static bool IsImage(string ext)
        {
            try
            {
                return ImageExtensions.Contains(ext.ToUpper());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
    }
}
