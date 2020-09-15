using System.Collections.Generic;

namespace HtmlGenerator.Presets.Presets
{
    public static class Head
    {
        public static IEnumerable<string> GetHead(string title)
        {
            yield return "<head>";
            yield return "<meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\">";
            yield return "<meta charset=\"utf-8\">";
            yield return $"<title>{title}</title>";
            yield return "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">";
            yield return "<meta name=\"description\" content=\"Algorithms and Data Structures in C#\">";
            yield return "<meta name=\"author\" content=\"Petro Kolosov\">";
            yield return "<meta name=\"keywords\" content=\"Data structures, Algorithms\">";
            yield return "<meta name=\"revisit-after\" content=\"3 days\">";
            yield return "<link rel=\"icon\" type=\"image/png\" href=\"css/favicon-16x16.png\" sizes=\"16x16\" />";
            yield return "<link rel=\"stylesheet\" type=\"text/css\" media=\"screen\" href=\"css/compScience.css\">";
            yield return "<link rel=\"stylesheet\" href=\"code_highlight_css/styles/darcula.css\">";
            yield return "<script src=\"code_highlight_css/highlight.pack.js\"></script>";
            yield return "<script>hljs.initHighlightingOnLoad();</script>";
            yield return "</head>";
        }
    }
}