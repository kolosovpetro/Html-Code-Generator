using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;

namespace HtmlGenerator.Concrete.Parameters.Menu
{
    public class RootParameter : IMenuParameter
    {
        public string DirectoryName => Path.MainRoot;
        public string SubTitle => Title.MainRoot;
    }
}