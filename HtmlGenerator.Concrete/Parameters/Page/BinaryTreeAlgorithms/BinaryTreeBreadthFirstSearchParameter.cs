using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeBreadthFirstSearchParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.BreadthFirstIterative;
        public string SubTitle => Title.BinaryTreeAlgorithms.BreadthFirstIterative;
        public string SnippetPath => Snippet.BinaryTreeAlgorithms.BreadthFirstIterative;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.BreadthFirstIterative;
    }
}