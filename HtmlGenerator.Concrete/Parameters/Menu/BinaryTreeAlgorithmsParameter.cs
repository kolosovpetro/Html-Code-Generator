using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class BinaryTreeAlgorithmsParameter : IMenuParameter
    {
        public string DirectoryName => Path.BinaryTreeAlgorithms.Root;
        public string SubTitle => Title.BinaryTreeAlgorithms.Root;
    }
}