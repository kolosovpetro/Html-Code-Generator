using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms
{
    public class BinarySearchTreeSuccessorParameter : IPageParameter
    {
        public string DirectoryName => Path.BinarySearchtAlgorithms.Successor;
        public string SubTitle => Title.BinarySerachTreeAlgorithms.Successor;
        public string SnippetPath => Snippet.BinarySearchTreeAlgorithms.Successor;
        public string Description => Routes.Route.Description.BinarySearchTreeAlgorithms.Successor;
    }
}