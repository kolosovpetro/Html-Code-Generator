using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeInOrderIterative : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.InOrderIterative;
        public string SubTitle => Path.BinaryTreeAlgorithms.InOrderIterative;
        public string SnippetPath => Snippet.BtAlgorithms.InOrderIterative;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.InOrderIterative;
    }
}