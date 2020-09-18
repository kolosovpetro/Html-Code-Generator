namespace HtmlGenerator.Abstractions.Interfaces
{
    public interface IPageParameter : IMenuParameter
    {
        string SnippetPath { get; }
        string Description { get; }
    }
}