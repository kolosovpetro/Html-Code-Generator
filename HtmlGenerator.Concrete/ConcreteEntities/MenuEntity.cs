using HtmlGenerator.Abstractions.Interfaces;

namespace HtmlGenerator.Concrete.ConcreteEntities
{
    public class MenuEntity : IEntity
    {
        public IEntity Parent { get; set; }
        public string DirectoryName { get; set; }
        public string Path { get; set; }
        public void Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}