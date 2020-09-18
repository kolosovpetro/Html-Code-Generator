using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.BinaryTreeAlgorithms
{
    public class BinaryTreeDepthParameter : IPageParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.Depth;
        public string SubTitle => Path.BinaryTreeAlgorithms.Depth;
        public string SnippetPath => Snippet.BtAlgorithms.Depth;
        public string Description => Routes.Route.Description.BinaryTreeAlgorithms.Depth;
    }
}