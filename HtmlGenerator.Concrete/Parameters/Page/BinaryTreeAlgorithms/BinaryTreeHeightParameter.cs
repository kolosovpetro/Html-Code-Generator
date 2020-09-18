using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeHeightParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.Height;
        public string SubTitle => Path.BinaryTreeAlgorithms.Height;
        public string SnippetPath => Snippet.BtAlgorithms.Height;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.Height;
    }
}