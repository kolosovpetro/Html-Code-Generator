using System.IO;
using HtmlGenerator.Abstractions.Interfaces;

namespace HtmlGenerator.Services.Writer
{
    public static class WriterService
    {
        public static void CreateFile(IEntity entity)
        {
            using var sw = new StreamWriter(entity.Path + entity.FileName);
            sw.WriteLine("test");
        }
    }
}