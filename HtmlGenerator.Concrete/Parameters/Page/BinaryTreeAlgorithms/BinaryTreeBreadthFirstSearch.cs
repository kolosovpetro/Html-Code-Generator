using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeBreadthFirstSearch : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.BreadthFirstIterative;
        public string SubTitle => Path.BinaryTreeAlgorithms.BreadthFirstIterative;
        public string SnippetPath => Snippet.BtAlgorithms.BreadthFirstIterative;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.BreadthFirstIterative;
    }
}