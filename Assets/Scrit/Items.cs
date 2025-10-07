using UnityEngine;

public abstract class Items : MonoBehaviour 
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;

    public string Name => _name;
    public string Description => _description;

    public Items (string name, string description)
    {
        _name = name;
        _description = description;
    }
    public virtual void MostrarInfo()
    {
        Debug.Log(Name + " "+ Description);
    }
}

