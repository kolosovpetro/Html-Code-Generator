using System.IO;
using System.Linq;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.CodeQueues.Queues;

namespace HtmlGenerator.Services.Writer
{
    public static class WriterService
    {
        public static void CreateFile(IEntity entity)
        {
            var queue = MenuHtml.MenuHtmlCodeQueue(entity);
            using var sw = new StreamWriter(entity.Path + entity.FileName);
            
            while (queue.Any()) 
                sw.WriteLine(queue.Dequeue());
        }
    }
}