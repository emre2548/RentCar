using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var sourcePath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            File.Move(sourcePath, (string)result);
            return (string)result;
        }

        public static void Delete(string path)
        {
            File.Delete(path);
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream((string)result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return (string)result;
        }

        private static object newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.Name);
            string fileExtansion = ff.Extension;

            string path = Environment.CurrentDirectory + @"\Images\carImages";
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtansion;

            string result = $@"{path}\{newPath}";
            return result;
        }
    }
}
