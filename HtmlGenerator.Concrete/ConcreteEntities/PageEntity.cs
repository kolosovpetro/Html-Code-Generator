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
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        
        

        public void AddChild(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Commit()
        {
            FolderService.Create(Path);
            WriterService.CreatePageItem(this, "snippetpath");
        }
    }
}