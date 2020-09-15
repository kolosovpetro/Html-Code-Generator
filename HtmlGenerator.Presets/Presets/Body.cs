using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Presets.Presets
{
    public static class Body
    {
        public static IEnumerable<string> BodyStart(string subtitle)
        {
            yield return "<body class=\"compScience\">";
            yield return $"<h1>{Titles.MainTitle}</h1>";
            yield return $"<h2>{subtitle}</h2>";
        }

        public static IEnumerable<string> GenerateLinks(IEntity entity)
        {
            return entity.ChildObjects.Select(x =>
                $"<li><a href=\"{x.DirectoryName}/{x.FileName}\">{x.DirectoryName}</li>");
        }
    }
}