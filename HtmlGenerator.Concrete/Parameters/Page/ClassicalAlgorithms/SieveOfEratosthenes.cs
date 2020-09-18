using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.ClassicalAlgorithms
{
    public class SieveOfEratosthenes : IPageParameter
    {
        public string DirectoryName => Path.ClassicalAlgorithms.SieveOfEratosthenes;
        public string SubTitle => Title.ClassicalAlgorithms.SieveOfEratosthenes;
        public string SnippetPath => Snippet.ClassicalAlgorithms.SieveOfEratosthenes;
        public string Description => Routes.Route.Description.ClassicalAlgorithms.SieveOfEratosthenes;
    }
}