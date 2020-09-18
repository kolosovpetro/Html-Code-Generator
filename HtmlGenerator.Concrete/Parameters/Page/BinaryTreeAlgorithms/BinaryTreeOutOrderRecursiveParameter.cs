using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeOutOrderRecursiveParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.OutOrderRecursive;
        public string SubTitle => Title.BinaryTreeAlgorithms.OutOrderRecursive;
        public string SnippetPath => Snippet.BinaryTreeAlgorithms.OutOrderRecursive;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.OutOrderRecursive;
    }
}