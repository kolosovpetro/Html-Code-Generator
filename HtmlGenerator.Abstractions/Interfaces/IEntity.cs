using System.Collections.Generic;

namespace HtmlGenerator.Abstractions.Interfaces
{
    public interface IEntity
    {
        /// <summary>
        /// Root node of current node
        /// </summary>
        IEntity Parent { get; set; }
        
        List<IEntity> ChildObjects { get; }
        
        /// <summary>
        /// Name of directory
        /// </summary>
        string DirectoryName { get; set; }
        
        /// <summary>
        /// Path of current node. Generally, it is Parent.Path + Directory
        /// </summary>
        string Path { get; set; }

        void AddChild(IEntity entity);

        /// <summary>
        /// Generates new file at folder debug/Path + Directory/FileName;
        /// Filename is to be constant index.htm
        /// </summary>
        void Commit();
    }
}