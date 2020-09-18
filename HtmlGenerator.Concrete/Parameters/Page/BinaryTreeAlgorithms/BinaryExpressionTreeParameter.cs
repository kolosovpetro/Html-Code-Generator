using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryExpressionTreeParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.ExpressionTree;
        public string SubTitle => Title.BinaryTreeAlgorithms.ExpressionTree;
        public string SnippetPath => Snippet.BinaryTreeAlgorithms.ExpressionTree;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.ExpressionTree;
    }
}