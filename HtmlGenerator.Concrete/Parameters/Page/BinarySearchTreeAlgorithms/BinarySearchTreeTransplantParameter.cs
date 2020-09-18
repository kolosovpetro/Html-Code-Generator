using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinarySearchTreeAlgorithms
{
    public class BinarySearchTreeTransplantParameter : IPageParameter
    {
        public string DirectoryName => Path.BinarySearchtAlgorithms.Transplant;
        public string SubTitle => Title.BinarySerachTreeAlgorithms.Transplant;
        public string SnippetPath => Snippet.BinarySearchTreeAlgorithms.Transplant;
        public string Description => Routes.Route.Description.BinarySearchTreeAlgorithms.Transplant;
    }
}