using System.IO;

namespace HtmlGenerator.Services.Folder
{
    public static class FolderService
    {
        public static void Create(string folderPath)
        {
            if (!Directory.Exists(folderPath)) 
                Directory.CreateDirectory(folderPath);
        }
    }
}