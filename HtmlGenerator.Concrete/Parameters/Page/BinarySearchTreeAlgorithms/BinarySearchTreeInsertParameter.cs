using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms
{
    public class BinarySearchTreeInsertParameter : IPageParameter
    {
        public string DirectoryName => Path.BinarySearchtAlgorithms.Insert;
        public string SubTitle => Title.BinarySerachTreeAlgorithms.Insert;
        public string SnippetPath => Snippet.BinarySearchTreeAlgorithms.Insert;
        public string Description => Routes.Route.Description.BinarySearchTreeAlgorithms.Insert;
    }
}