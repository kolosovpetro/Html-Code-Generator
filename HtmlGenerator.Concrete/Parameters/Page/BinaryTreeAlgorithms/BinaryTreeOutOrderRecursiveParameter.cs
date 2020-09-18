using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeOutOrderRecursiveParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.OutOrderRecursive;
        public string SubTitle => Path.BinaryTreeAlgorithms.OutOrderRecursive;
        public string SnippetPath => Snippet.BtAlgorithms.OutOrderRecursive;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.OutOrderRecursive;
    }
}