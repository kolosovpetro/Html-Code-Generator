using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeInOrderRecursiveParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.InOrderRecursive;
        public string SubTitle => Title.BinaryTreeAlgorithms.InOrderRecursive;
        public string SnippetPath => Snippet.BinaryTreeAlgorithms.InOrderRecursive;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.InOrderRecursive;
    }
}