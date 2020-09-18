using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreePreOrderIterativeParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.PreOrderIterative;
        public string SubTitle => Path.BinaryTreeAlgorithms.PreOrderIterative;
        public string SnippetPath => Snippet.BtAlgorithms.PreOrderIterative;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.PreOrderIterative;
    }
}