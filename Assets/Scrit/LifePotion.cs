using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class LifePotion : Items, IConsumible
{
    private int _healing;

    public int Healing => _healing;
    public LifePotion( string name, string descriccion, int Healing) : base(name, descriccion) 
    {
        _healing = Healing;
    }

    public void Consumir()
    {
        Debug.Log(Name + " cunsumida. cura " + Healing + " puntos de vida");
    }
}
