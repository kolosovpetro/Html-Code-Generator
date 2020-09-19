using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Presets.HtmlCodePresets;

namespace HtmlGenerator.CodeQueues.Queues
{
    public static class PageHtmlCodeSource
    {
        public static Queue<string> PageHtmlCodeQueue(IEntity entity, string snippetPath)
        {
            var queue = new Queue<string>();
            queue.Enqueue("<html>");
            Head.GetHead(entity.Title).ToList().ForEach(queue.Enqueue);
            Body.BodyStart(entity.SubTitle).ToList().ForEach(queue.Enqueue);
            queue.Enqueue("<ul>");
            queue.Enqueue("<li><a href=\"https://github.com/kolosovpetro/Html-Code-Generator\">Source</a></li>");
            Body.GenerateLinks(entity).ToList().ForEach(queue.Enqueue);
            queue.Enqueue("</ul>");
            CodeSnippet.CodeSnippetStart().ToList().ForEach(queue.Enqueue);
            CodeSnippet.ReadAlgorithmFromFile(snippetPath).ToList().ForEach(queue.Enqueue);
            CodeSnippet.CodeSnippetWrapper().ToList().ForEach(queue.Enqueue);
            queue.Enqueue("</body>");
            queue.Enqueue("</html>");
            return queue;
        }

        public static Queue<string> PageHtmlCodeQueue(IEntity entity, string snippetPath, string description)
        {
            var queue = new Queue<string>();
            queue.Enqueue("<html>");
            Head.GetHead(entity.Title).ToList().ForEach(queue.Enqueue);
            Body.BodyStart(entity.SubTitle).ToList().ForEach(queue.Enqueue);
            queue.Enqueue($"<h3>Description</h3> {description}");
            queue.Enqueue("<ul>");
            queue.Enqueue("<li><a href=\"https://github.com/kolosovpetro/Html-Code-Generator\">Source</a></li>");
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