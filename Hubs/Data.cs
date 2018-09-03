using System.Collections.Generic;

public class FlareItem
{
    public string Name {get; set;}
    public int? Size {get; set;}

    public List<FlareItem> Children {get; set;}
}