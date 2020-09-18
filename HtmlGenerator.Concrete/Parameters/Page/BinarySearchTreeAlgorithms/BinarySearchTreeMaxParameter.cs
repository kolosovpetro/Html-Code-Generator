using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms
{
    public class BinarySearchTreeMaxParameter : IPageParameter
    {
        public string DirectoryName => Path.BinarySearchtAlgorithms.Max;
        public string SubTitle => Title.BinarySerachTreeAlgorithms.Max;
        public string SnippetPath => Snippet.BinarySearchTreeAlgorithms.Max;
        public string Description => Routes.Route.Description.BinarySearchTreeAlgorithms.Max;
    }
}