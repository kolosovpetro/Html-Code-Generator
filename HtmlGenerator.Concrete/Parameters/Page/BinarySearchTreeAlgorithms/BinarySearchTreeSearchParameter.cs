using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms
{
    public class BinarySearchTreeSearchParameter : IPageParameter
    {
        public string DirectoryName => Path.BinarySearchtAlgorithms.Search;
        public string SubTitle => Title.BinarySerachTreeAlgorithms.Search;
        public string SnippetPath => Snippet.BinarySearchTreeAlgorithms.Search;
        public string Description => Routes.Route.Description.BinarySearchTreeAlgorithms.Search;
    }
}