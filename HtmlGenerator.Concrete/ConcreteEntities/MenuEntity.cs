using System.Collections.Generic;
using HtmlGenerator.Abstractions.Interfaces;

namespace HtmlGenerator.Concrete.ConcreteEntities
{
    public class MenuEntity : IEntity
    {
        public IEntity Parent { get; set; }
        public List<IEntity> ChildObjects { get; } = new List<IEntity>();
        public string DirectoryName { get; set; }
        public string Path { get; set; }

        public MenuEntity()
        {
        }

        public MenuEntity(string directoryName)
        {
            DirectoryName = directoryName;
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
            throw new System.NotImplementedException();
        }
    }
}