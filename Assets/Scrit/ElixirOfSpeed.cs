using System.Data;
using UnityEngine;

public class ElixirOfSpeed : Items, IConsumible, IAplicarBuff
{
    private int _speedincrease;
    private int _duration;
    public int Speedincrease => _speedincrease;
    public int Duration => _duration;
    public ElixirOfSpeed(string name, string description,int speedincrease, int duration) : base(name, description)
    {
        _speedincrease = speedincrease;
        _duration = duration;

    }

    public void AplicarBuff(GameObject objet)
    {
        Debug.Log("Se aplicó buff de velocidad a " + objet.name);
    }

    public void Consumir()
    {
         Debug.Log( Name + "consumido. Aplica buff de velocidad de " + Speedincrease +  " por " + Duration + " segundos.");
    }
    
}
