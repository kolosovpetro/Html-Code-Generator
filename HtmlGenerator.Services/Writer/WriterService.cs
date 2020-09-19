using System.IO;
using System.Linq;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.CodeQueues.Queues;

namespace HtmlGenerator.Services.Writer
{
    public static class WriterService
    {
        public static void CreateMenuItem(IEntity entity)
        {
            var queue = MenuHtmlCodeSource.MenuHtmlCodeQueue(entity);
            using var sw = new StreamWriter(entity.Path + entity.FileName);
            
            while (queue.Any()) 
                sw.WriteLine(queue.Dequeue());
        }
        
        public static void CreatePageItem(IEntity entity, string snippetPath)
        {
            var queue = PageHtmlCodeSource.PageHtmlCodeQueue(entity, snippetPath);
            using var sw = new StreamWriter(entity.Path + entity.FileName);
            
            while (queue.Any()) 
                sw.WriteLine(queue.Dequeue());
        }
        
        public static void CreatePageItem(IEntity entity, string snippetPath, string description)
        {
            var queue = PageHtmlCodeSource.PageHtmlCodeQueue(entity, snippetPath, description);
            using var sw = new StreamWriter(entity.Path + entity.FileName);
            
            while (queue.Any()) 
                sw.WriteLine(queue.Dequeue());
        }
    }
}