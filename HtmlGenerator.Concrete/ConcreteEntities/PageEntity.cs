using System.Collections.Generic;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Services.Folder;
using HtmlGenerator.Services.Writer;

namespace HtmlGenerator.Concrete.ConcreteEntities
{
    public class PageEntity : IEntity
    {
        private string SnippetPath { get; }
        public IEntity Parent { get; set; }
        public List<IEntity> ChildObjects { get; } = new List<IEntity>();
        public string DirectoryName { get; set; }
        public string FileName { get; set; } = "index.htm";
        public string Path { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        private string Description { get; }

        public PageEntity(string directoryName, string subTitle, string snippetPath, string description)
        {
            SnippetPath = snippetPath;
            DirectoryName = directoryName;
            SubTitle = subTitle;
            Description = description;
            Title = subTitle;
        }

        public PageEntity(IPageParameter parameter)
        {
            SnippetPath = parameter.SnippetPath;
            DirectoryName = parameter.DirectoryName;
            SubTitle = parameter.SubTitle;
            Description = parameter.Description;
            Title = parameter.SubTitle;
        }

        public void AddChild(IEntity entity)
        {
            ChildObjects.Add(entity);
            entity.Parent = this;
            entity.Path = Path + entity.DirectoryName;
        }

        public void Commit()
        {
            FolderService.Create(Path);
            WriterService.CreatePageItem(this, SnippetPath, Description);
        }
    }
}