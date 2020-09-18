using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.GraphAlgorithms
{
    public class GraphDepthFirstIterativeParameter : IPageParameter
    {
        public string DirectoryName => Path.GraphAlgorithms.DepthFirstIterative;
        public string SubTitle => Title.GraphAlgorithms.DepthFirstIterative;
        public string SnippetPath => Snippet.GraphAlgorithms.DepthFirstIterative;
        public string Description => Routes.Route.Description.GraphAlgorithms.DepthFirstIterative;
    }
}