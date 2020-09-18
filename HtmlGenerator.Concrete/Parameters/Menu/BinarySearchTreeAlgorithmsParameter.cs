using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class BinarySearchTreeAlgorithmsParameter : IMenuParameter
    {
        public string DirectoryName => Path.BinarySearchtAlgorithms.Root;
        public string SubTitle => Title.BinarySerachTreeAlgorithms.Root;
    }
}