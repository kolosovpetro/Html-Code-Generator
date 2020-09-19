using System.Collections.Generic;
using System.IO;

namespace HtmlGenerator.Presets.HtmlCodePresets
{
    public static class CodeSnippet
    {
        public static IEnumerable<string> CodeSnippetStart()
        {
            yield return "<h3>Code snippet</h3>";
            yield return "<div class=\"common\">";
            yield return "<pre><code class=\"csharp\">";
        }

        public static IEnumerable<string> ReadAlgorithmFromFile(string path)
        {
            return File.ReadLines(path);
        }

        public static IEnumerable<string> CodeSnippetWrapper()
        {
            yield return "</code></pre>";
            yield return "</div>";
        }
    }
}