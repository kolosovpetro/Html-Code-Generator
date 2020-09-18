using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.GraphAlgorithms
{
    public class GraphBreadthFirstParameter : IPageParameter
    {
        public string DirectoryName => Path.GraphAlgorithms.BreadthFirst;
        public string SubTitle => Title.GraphAlgorithms.BreadthFirst;
        public string SnippetPath => Snippet.GraphAlgorithms.BreadthFirst;
        public string Description => Routes.Route.Description.GraphAlgorithms.BreadthFirst;
    }
}