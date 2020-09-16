using System.Collections.Generic;
using HtmlGenerator.Abstractions.Interfaces;
using HtmlGenerator.Routes.Route;
using HtmlGenerator.Services.Concrete;
using HtmlGenerator.Services.Folder;
using HtmlGenerator.Services.Writer;

namespace HtmlGenerator.Concrete.ConcreteEntities
{
    public class MenuEntity : IEntity
    {
        public IEntity Parent { get; set; }
        public List<IEntity> ChildObjects { get; } = new List<IEntity>();
        public string DirectoryName { get; set; }

        public string FileName { get; set; } = "index.htm";
        public string Path { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public MenuEntity(string directoryName)
        {
            DirectoryName = directoryName;
            Path = Parent?.Path + directoryName;
        }

        public MenuEntity(string directoryName, string subTitle)
        {
            DirectoryName = directoryName;
            SubTitle = subTitle;
            Title = subTitle;
            Path = Parent?.Path + directoryName;
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
            WriterService.CreateMenuItem(this);
        }
    }
}