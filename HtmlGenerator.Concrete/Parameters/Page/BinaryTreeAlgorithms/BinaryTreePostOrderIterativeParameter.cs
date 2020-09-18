using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreePostOrderIterativeParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.PostOrderIterative;
        public string SubTitle => Title.BinaryTreeAlgorithms.PostOrderIterative;
        public string SnippetPath => Snippet.BinaryTreeAlgorithms.PostOrderIterative;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.PostOrderIterative;
    }
}