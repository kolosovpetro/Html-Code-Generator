using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.ClassicalAlgorithms
{
    public class EuclideanGcdParameter : IPageParameter
    {
        public string DirectoryName => Path.ClassicalAlgorithms.EuclideanGcd;
        public string SubTitle => Title.ClassicalAlgorithms.EuclideanGcd;
        public string SnippetPath => Snippet.ClassicalAlgorithms.EuclideanGcd;
        public string Description => Routes.Route.Description.ClassicalAlgorithms.EuclideanGcd;
    }
}