using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SearchAlgorithms
{
    public class ImprovedLinearSearchWithSentinel : IPageParameter
    {
        public string DirectoryName => Path.SearchAlgorithms.ImprovedLinearSearchWithSentinel;
        public string SubTitle => Title.SearchAlgorithms.ImprovedLinearSearchWithSentinel;
        public string SnippetPath => Snippet.SearchAlgorithms.ImprovedLinearSearchWithSentinel;
        public string Description => Routes.Route.Description.SearchAlgorithms.ImprovedLinearSearchWithSentinel;
    }
}