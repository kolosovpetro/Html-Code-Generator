using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreePostOrderRecursiveParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.PostOrderRecursive;
        public string SubTitle => Title.BinaryTreeAlgorithms.PostOrderRecursive;
        public string SnippetPath => Snippet.BinaryTreeAlgorithms.PostOrderRecursive;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.PostOrderRecursive;
    }
}