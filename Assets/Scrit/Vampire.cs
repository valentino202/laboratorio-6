using UnityEngine;

public class Vampire : Enemy
{
    public Vampire(string name, int life, int level) : base(name, life, level) { }

    public override void SpecialAbility()
    {
        Debug.Log(Name + " usa robo de vida recupera salud ");
    }
    private void Start()
    {
        ShowStatus();
    }
}
