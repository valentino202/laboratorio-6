using UnityEngine;

public abstract class Enemy 
{
    private string name;
    private int life = 10;
    private int level = 1;


    public string Name => name;
    public int Level => level;
    public int Life => life;


    public Enemy (string name)
    {
        this.name = name;
       
    }
    public Enemy(string name, int life, int level)
    {
        this.name = name;
        this.life = life;
        this.level = level;
    }

    public abstract void SpecialAbility();

    protected void ShowStatus()
    {
        Debug.Log("el : " +  Name +  "vida: " + Life + "nivel: " + Level);
    }
}
