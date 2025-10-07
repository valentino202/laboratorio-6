using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
   [SerializeField] private string enemyname;
   [SerializeField] private int life = 10;
   [SerializeField] private int level = 1;


    public string Name => enemyname;
    public int Level => level;
    public int Life => life;


    public Enemy(string name, int life, int level)
    {
        this.name = name;
        this.life = life;
        this.level = level;
    }

    public void SetLife(int newLife) => life = Mathf.Max(0, newLife);
    public void SetLevel(int newLevel) => level = Mathf.Max(1, newLevel);


    public abstract void SpecialAbility();

    protected void ShowStatus()
    {
        Debug.Log("el : " +  Name +  "vida: " + Life + "nivel: " + Level);
    }
}
