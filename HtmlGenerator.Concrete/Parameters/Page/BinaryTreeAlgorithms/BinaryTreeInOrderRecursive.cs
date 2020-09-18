using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeInOrderRecursive : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.InOrderRecursive;
        public string SubTitle => Path.BinaryTreeAlgorithms.InOrderRecursive;
        public string SnippetPath => Snippet.BtAlgorithms.InOrderRecursive;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.InOrderRecursive;
    }
}