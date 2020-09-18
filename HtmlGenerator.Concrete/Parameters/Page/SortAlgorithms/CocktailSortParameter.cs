using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SortAlgorithms
{
    public class CocktailSortParameter : IPageParameter
    {
        public string DirectoryName => Path.SortAlgorithms.CocktailSort;
        public string SubTitle => Title.SortAlgorithms.CocktailSort;
        public string SnippetPath => Snippet.SortAlgorithms.CocktailSort;
        public string Description => Routes.Route.Description.SortAlgorithms.CocktailSort;
    }
}