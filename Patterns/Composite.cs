using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Generalizes composites and leafs as components to call them equally
/// Example: file system, flocking systems, skill-trees (Assasins Creed)
/// Link: https://www.dofactory.com/net/composite-design-pattern
///       https://www.c-sharpcorner.com/article/composite-design-pattern/
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{
    /// <summary>
    /// The base component for leaf and composite
    /// </summary>
    public abstract class FileSystemComponent
    {
        public string _name;
        public FileSystemComponent(string name)
        {
            _name = name;
        }
    }

    /// <summary>
    /// The leaf node
    /// </summary>
    public class FileItem : FileSystemComponent
    {
        public long _fileBytes;
        public FileItem(string name, long fileBytes) : base(name)
        {
            _fileBytes = fileBytes;
            Console.WriteLine($"Created file node: {_name} [{_fileBytes} KB]");
        }
    }

    /// <summary>
    /// The composite that can contain more children of type FileSystemComponent
    /// </summary>
    public class Directory : FileSystemComponent
    {
        public List<FileSystemComponent> _children = new List<FileSystemComponent>();

        public Directory(string name) : base(name)
        {
            Console.WriteLine($"Created directory: {_name}");
        }

        public List<FileSystemComponent> GetChildren()
        {
            return _children;
        }
        public void Add(FileSystemComponent _childNote)
        {
            _children.Add(_childNote);
        }        
        public void Remove(FileSystemComponent _childNote)
        {
            _children.Remove(_childNote);
        }
    }
}
