using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Services.Folder;
using HtmlGenerator.Services.Writer;

namespace HtmlGenerator.Services.Concrete
{
    public static class ConcreteService
    {
        public static void CreateFolders(IEntity entity)
        {
            var queue = new Queue<IEntity>();
            
            queue.Enqueue(entity);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                FolderService.Create(current.Path);
                current.ChildObjects.ForEach(queue.Enqueue);
            }
        }

        public static void CreateFiles(IEntity entity)
        {
            var queue = new Queue<IEntity>();
            
            queue.Enqueue(entity);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                WriterService.CreateFile(current);
                current.ChildObjects.ForEach(queue.Enqueue);
            }
        }
    }
}