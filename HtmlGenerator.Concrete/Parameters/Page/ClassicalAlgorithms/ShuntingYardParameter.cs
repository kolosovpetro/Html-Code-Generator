using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.ClassicalAlgorithms
{
    public class ShuntingYardParameter : IPageParameter
    {
        public string DirectoryName => Path.ClassicalAlgorithms.ShuntingYard;
        public string SubTitle => Title.ClassicalAlgorithms.ShuntingYard;
        public string SnippetPath => Snippet.ClassicalAlgorithms.ShuntingYard;
        public string Description => Routes.Route.Description.ClassicalAlgorithms.ShuntingYard;
    }
}