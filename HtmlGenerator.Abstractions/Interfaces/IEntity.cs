﻿using System.Collections.Generic;

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
        /// Name of file
        /// </summary>
        string FileName { get; set; }
        
        /// <summary>
        /// Path of current node. Generally, it is Parent.Path + Directory
        /// </summary>
        string Path { get; set; }
        
        /// <summary>
        /// Title h1.
        /// </summary>
        string Title { get; set; }
        
        /// <summary>
        /// Title h2.
        /// </summary>
        string SubTitle { get; set; }
        
        /// <summary>
        /// Adds new child entity to current
        /// </summary>
        void AddChild(IEntity entity);

        /// <summary>
        /// Adds a range of child entities to current
        /// </summary>
        void AddChildRange(params IEntity[] entities);

        /// <summary>
        /// Generates new file at folder debug/Path + Directory/FileName;
        /// Filename is to be constant index.htm
        /// </summary>
        void Commit();
    }
}