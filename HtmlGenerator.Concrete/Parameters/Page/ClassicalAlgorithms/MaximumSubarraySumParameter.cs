using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Page.ClassicalAlgorithms
{
    public class MaximumSubarraySumParameter : IPageParameter
    {
        public string DirectoryName => Path.ClassicalAlgorithms.MaximumSubarraySum;
        public string SubTitle => Title.ClassicalAlgorithms.MaximumSubarraySum;
        public string SnippetPath => Snippet.ClassicalAlgorithms.MaximumSubarraySum;
        public string Description => Routes.Route.Description.ClassicalAlgorithms.MaximumSubarraySum;
    }
}