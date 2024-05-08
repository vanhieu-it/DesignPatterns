using System;
using System.Collections.Generic;

// Component interface
public abstract class FileSystemItem
{
    protected string name;

    public FileSystemItem(string name)
    {
        this.name = name;
    }

    public abstract void Print(int depth);
}

// Leaf class
public class File : FileSystemItem
{
    public File(string name) : base(name)
    {
    }

    public override void Print(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);
    }
}

// Composite class
public class Directory : FileSystemItem
{
    private List<FileSystemItem> children = new List<FileSystemItem>();

    public Directory(string name) : base(name)
    {
    }

    public void AddItem(FileSystemItem item)
    {
        children.Add(item);
    }

    public void RemoveItem(FileSystemItem item)
    {
        children.Remove(item);
    }

    public override void Print(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);

        // Print each child
        foreach (var child in children)
        {
            child.Print(depth + 2);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a folder structure
        Directory root = new Directory("Root");
        root.AddItem(new File("File A"));
        root.AddItem(new File("File B"));

        Directory folderX = new Directory("Folder X");
        folderX.AddItem(new File("File XA"));
        folderX.AddItem(new File("File XB"));

        root.AddItem(folderX);

        Directory folderY = new Directory("Folder Y");
        folderY.AddItem(new File("File YA"));
        folderY.AddItem(new File("File YB"));

        folderX.AddItem(folderY);

        // Print the folder structure
        root.Print(1);
    }
}
