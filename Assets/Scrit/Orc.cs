using UnityEngine;

public class Orc : Enemy
{
     public Orc (string name, int life, int level)  : base (name, life, level){ }

    public override void SpecialAbility()
    {
        Debug.Log(Name + " usa furia de berserker");
    }

    private void Start()
    {
        ShowStatus();
    }
}
