using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms
{
    public class BinarySearchTreeDeleteParameter : IPageParameter
    {
        public string DirectoryName => Path.BinarySearchtAlgorithms.Delete;
        public string SubTitle => Title.BinarySerachTreeAlgorithms.Delete;
        public string SnippetPath => Snippet.BinarySearchTreeAlgorithms.Delete;
        public string Description => Routes.Route.Description.BinarySearchTreeAlgorithms.Delete;
    }
}