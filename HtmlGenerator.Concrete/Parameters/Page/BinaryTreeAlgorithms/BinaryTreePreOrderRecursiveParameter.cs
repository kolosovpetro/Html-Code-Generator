using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreePreOrderRecursiveParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.PreOrderRecursive;
        public string SubTitle => Path.BinaryTreeAlgorithms.PreOrderRecursive;
        public string SnippetPath => Snippet.BtAlgorithms.PreOrderRecursive;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.PreOrderRecursive;
    }
}