using UnityEngine;

public abstract class Items 
{
    private string _name;
    private string _description;

    public string Name => _name;
    public string Description => _description;

    public Items (string name, string description)
    {
        _name = name;
        _description = description;
    }   
}
