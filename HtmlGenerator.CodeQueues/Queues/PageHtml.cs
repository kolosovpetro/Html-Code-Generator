using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Presets.Presets;

namespace HtmlGenerator.CodeQueues.Queues
{
    public static class PageHtml
    {
        public static Queue<string> PageHtmlCodeQueue(string title, string subtitle, string path,
            IEntity file)
        {
            var queue = new Queue<string>();
            queue.Enqueue("<html>");
            Head.GetHead(title).ToList().ForEach(queue.Enqueue);
            Body.BodyStart(subtitle).ToList().ForEach(queue.Enqueue);
            queue.Enqueue("<ul>");
            Body.GenerateLinks(file).ToList().ForEach(queue.Enqueue);
            queue.Enqueue("</ul>");
            CodeSnippet.CodeSnippetStart().ToList().ForEach(queue.Enqueue);
            CodeSnippet.ReadAlgorithmFromFile(path).ToList().ForEach(queue.Enqueue);
            CodeSnippet.CodeSnippetWrapper().ToList().ForEach(queue.Enqueue);
            queue.Enqueue("</body>");
            queue.Enqueue("</html>");
            return queue;
        }
    }
}