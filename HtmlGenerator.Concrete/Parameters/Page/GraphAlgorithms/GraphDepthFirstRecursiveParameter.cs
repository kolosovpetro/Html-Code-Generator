using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.GraphAlgorithms
{
    public class GraphDepthFirstRecursiveParameter : IPageParameter
    {
        public string DirectoryName => Path.GraphAlgorithms.DepthFirstRecursive;
        public string SubTitle => Title.GraphAlgorithms.DepthFirstRecursive;
        public string SnippetPath => Snippet.GraphAlgorithms.DepthFirstRecursive;
        public string Description => Routes.Route.Description.GraphAlgorithms.DepthFirstRecursive;
    }
}