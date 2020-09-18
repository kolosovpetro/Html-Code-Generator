using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreePostOrderIterativeParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.PostOrderIterative;
        public string SubTitle => Path.BinaryTreeAlgorithms.PostOrderIterative;
        public string SnippetPath => Snippet.BtAlgorithms.PostOrderIterative;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.PostOrderIterative;
    }
}