using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Presets.HtmlCodePresets;

namespace HtmlGenerator.CodeQueues.Queues
{
    public static class MenuHtmlCodeSource
    {
        public static Queue<string> MenuHtmlCodeQueue(IEntity entity)
        {
            var queue = new Queue<string>();
            queue.Enqueue("<html>");
            Head.GetHead(entity.Title).ToList().ForEach(queue.Enqueue);
            Body.BodyStart(entity.SubTitle).ToList().ForEach(queue.Enqueue);
            queue.Enqueue("<ul>");
            Body.GenerateLinks(entity).ToList().ForEach(queue.Enqueue);
            queue.Enqueue("</ul>");
            queue.Enqueue("</body>");
            queue.Enqueue("</html>");
            return queue;
        }
    }
}