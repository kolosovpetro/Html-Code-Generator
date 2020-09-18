using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeInOrderIterativeParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.InOrderIterative;
        public string SubTitle => Title.BinaryTreeAlgorithms.InOrderIterative;
        public string SnippetPath => Snippet.BinaryTreeAlgorithms.InOrderIterative;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.InOrderIterative;
    }
}