using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace PresentationLayer.Helpers
{
    public class DocumentSettings
    {
        // Upload function
        public static string UploadFile(IFormFile file, string FolderName)
        {
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", FolderName);
            string FileName = $"{Guid.NewGuid()}" + file.FileName;
            string FilePath = Path.Combine(FolderPath, FileName);

            var FS = new FileStream(FilePath, FileMode.Create);

            file.CopyTo(FS);

            return FileName;
        }

        public static void DeleteFile(string FileName, string FolderName)
        {
            if (FileName is null || FolderName is null)
                return;

            string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", FolderName, FileName);

            if (File.Exists(FilePath))
                File.Delete(FilePath);

        }

    }
}
