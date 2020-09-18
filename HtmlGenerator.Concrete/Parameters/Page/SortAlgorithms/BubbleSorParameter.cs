using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.SortAlgorithms
{
    public class BubbleSorParameter : IPageParameter
    {
        public string DirectoryName => Path.SortAlgorithms.BubbleSort;
        public string SubTitle => Title.SortAlgorithms.BubbleSort;
        public string SnippetPath => Snippet.SortAlgorithms.BubbleSort;
        public string Description => Routes.Route.Description.SortAlgorithms.BubbleSort;
    }
}