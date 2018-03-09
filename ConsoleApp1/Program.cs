using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
public class Node
{
    public Node LeftChild { get; private set; }
    public Node RightChild { get; private set; }

    public Node(Node leftChild, Node rightChild)
    {
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }

    public int Height()
    {
        return FindHeight(this);
    }

    private int FindHeight(Node node)
    {
        if (node == null) return 0;
        return 1 + Math.Max(FindHeight(LeftChild), FindHeight(RightChild));
    }

    public static void Main(string[] args)
    {
        Node leaf1 = new Node(null, null);
        Node leaf2 = new Node(null, null);
        Node node = new Node(leaf1, null);
        Node root = new Node(node, leaf2);

        Console.WriteLine(root.Height());
    }
}/*
public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        XmlDocument doc = new XmlDocument();
        using (StringReader s = new StringReader(xml))
        {
            doc.Load(s);
        }
        var nodes = doc.SelectNodes("//*[starts-with(@name,'" + startingLetter + "')]");

        var list = new List<string>();
        foreach (XmlNode n in nodes)
        {
            list.Add(n.Attributes["name"].InnerText);
        }
        return list;
    }

    public static void Main(string[] args)
    {
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
    }
}
*/
