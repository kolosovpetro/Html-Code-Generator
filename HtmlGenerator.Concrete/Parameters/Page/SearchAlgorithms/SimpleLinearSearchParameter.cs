using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SearchAlgorithms
{
    public class SimpleLinearSearchParameter : IPageParameter
    {
        public string DirectoryName => Path.SearchAlgorithms.SimpleLinearSearch;
        public string SubTitle => Title.SearchAlgorithms.SimpleLinearSearch;
        public string SnippetPath => Snippet.SearchAlgorithms.SimpleLinearSearch;
        public string Description => Routes.Route.Description.SearchAlgorithms.SimpleLinearSearch;
    }
}