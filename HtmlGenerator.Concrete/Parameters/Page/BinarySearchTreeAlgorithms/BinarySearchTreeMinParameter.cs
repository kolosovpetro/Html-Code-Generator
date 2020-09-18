using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms
{
    public class BinarySearchTreeMinParameter : IPageParameter
    {
        public string DirectoryName => Path.BinarySearchtAlgorithms.Min;
        public string SubTitle => Title.BinarySerachTreeAlgorithms.Min;
        public string SnippetPath => Snippet.BinarySearchTreeAlgorithms.Min;
        public string Description => Routes.Route.Description.BinarySearchTreeAlgorithms.Min;
    }
}