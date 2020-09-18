using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeHeightParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.Height;
        public string SubTitle => Title.BinaryTreeAlgorithms.Height;
        public string SnippetPath => Snippet.BinaryTreeAlgorithms.Height;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.Height;
    }
}