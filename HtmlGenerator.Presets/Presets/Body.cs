using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Presets.Presets
{
    public static class Body
    {
        public static IEnumerable<string> BodyStart(string subtitle)
        {
            yield return "<body class=\"compScience\">";
            yield return $"<h1>{Title.Root}</h1>";
            yield return $"<h2>{subtitle}</h2>";
        }
        
        public static IEnumerable<string> BodyStart(string subtitle, string description)
        {
            yield return "<body class=\"compScience\">";
            yield return $"<h1>{Title.Root}</h1>";
            yield return $"<h2>{subtitle}</h2>";
            yield return $"<h3>Description: {description}</h3>";
        }

        public static IEnumerable<string> GenerateLinks(IEntity entity)
        {
            var list = entity.ChildObjects.Select(x =>
                $"<li><a href=\"{x.DirectoryName}\">{FormatFolderName(x.DirectoryName)}</li>").ToList();

            if (entity.Parent != null)
            {
                list.Add("<li><a href=\"../\">Back</a></li>");
            }

            return list;
        }

        public static IEnumerable<string> SplitOnCapitals(string text)
        {
            var regex = new Regex(@"\p{Lu}\p{Ll}*");
            foreach (Match match in regex.Matches(text))
                yield return match.Value;
        }

        public static string FormatFolderName(string folderName)
        {
            var builder = new StringBuilder();

            foreach (var word in SplitOnCapitals(folderName))
                builder.Append(" " + word);

            return builder.ToString().TrimStart();
        }
    }
}