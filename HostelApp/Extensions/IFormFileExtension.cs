﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Extensions
{
    public static class IFormFileExtension
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public async static Task<string> SaveAsync(this IFormFile file, string root, string mainFolder, string childFolder)
        {
            string path = Path.Combine(root, mainFolder, childFolder);
            string image = Guid.NewGuid().ToString() + file.FileName;
            string resultPath = Path.Combine(path, image);

            using(FileStream fileStream=new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return image;
        }

        public static void RemoveFile(string root, string mainFolder, string childFolder, string fileName)
        {
            string path = Path.Combine(root, mainFolder, childFolder, fileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
    }
}
