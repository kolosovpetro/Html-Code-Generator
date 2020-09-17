using System.Collections.Generic;
using HtmlGenerator.Routes.Route;

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
            yield return "<meta name=\"description\" content=\"Web-site dedicated to study of Algorithms and Data Structures. All Examples are in C#.\">";
            yield return "<meta name=\"author\" content=\"Petro Kolosov\">";
            yield return "<meta name=\"keywords\" content=\"Data structures, Algorithms\">";
            yield return "<meta name=\"revisit-after\" content=\"3 days\">";
            yield return "<meta name=\"twitter:site\" content=\"https://kolosovpetro.github.io/Html-Code-Generator/RootFolder\" />";
            yield return "<meta name=\"twitter:title\" content=\"Algorithms and Data Structures in C#\" />";
            yield return "<meta name=\"twitter:description\" content=\"Web-site dedicated to study of Algorithms and Data Structures. All Examples are in C#.\" />";
            yield return $"<meta name=\"twitter:image\" content=\"{Domain.MainDomain}css/card_image.jpg\" />";
            yield return $"<link rel=\"icon\" type=\"image/png\" href=\"{Domain.MainDomain}css/favicon-16x16.png\" sizes=\"16x16\" />";
            yield return
                $"<link rel=\"stylesheet\" type=\"text/css\" media=\"screen\" href=\"{Domain.MainDomain}css/compScience.css\">";
            yield return $"<link rel=\"stylesheet\" href=\"{Domain.MainDomain}css/darcula.css\">";
            yield return $"<script src=\"{Domain.MainDomain}css/highlight.pack.js\"></script>";
            yield return "<script>hljs.initHighlightingOnLoad();</script>";
            yield return "</head>";
        }
    }
}