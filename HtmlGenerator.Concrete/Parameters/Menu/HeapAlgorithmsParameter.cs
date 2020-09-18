using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class HeapAlgorithmsParameter : IMenuParameter
    {
        public string DirectoryName => Path.HeapAlgorithms.Root;
        public string SubTitle => Title.HeapAlgorithms.Root;
    }
}