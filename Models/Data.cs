using System.Collections.Generic;

public class Node
{
    public long Parent {get; set;}
    public long Id {get; set;}
    public string Name {get; set;}

    public List<Node> Children {get; set;}
}