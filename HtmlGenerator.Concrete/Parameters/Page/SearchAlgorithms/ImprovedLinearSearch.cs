using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SearchAlgorithms
{
    public class ImprovedLinearSearch : IPageParameter
    {
        public string DirectoryName => Path.SearchAlgorithms.ImprovedLinearSearch;
        public string SubTitle => Title.SearchAlgorithms.ImprovedLinearSearch;
        public string SnippetPath => Snippet.SearchAlgorithms.ImprovedLinearSearch;
        public string Description => Routes.Route.Description.SearchAlgorithms.ImprovedLinearSearch;
    }
}