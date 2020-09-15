using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Presets.Presets;

namespace HtmlGenerator.CodeQueues.Queues
{
    public static class PageHtml
    {
        public static Queue<string> PageHtmlCodeQueue(IEntity entity, string snippetPath)
        {
            var queue = new Queue<string>();
            queue.Enqueue("<html>");
            Head.GetHead().ToList().ForEach(queue.Enqueue);
            Body.BodyStart(entity.SubTitle).ToList().ForEach(queue.Enqueue);
            queue.Enqueue("<ul>");
            Body.GenerateLinks(entity).ToList().ForEach(queue.Enqueue);
            queue.Enqueue("</ul>");
            CodeSnippet.CodeSnippetStart().ToList().ForEach(queue.Enqueue);
            CodeSnippet.ReadAlgorithmFromFile(snippetPath).ToList().ForEach(queue.Enqueue);
            CodeSnippet.CodeSnippetWrapper().ToList().ForEach(queue.Enqueue);
            queue.Enqueue("</body>");
            queue.Enqueue("</html>");
            return queue;
        }
    }
}