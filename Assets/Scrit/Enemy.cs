using UnityEngine;
using static UnityEditor.Progress;

public abstract class Enemy : MonoBehaviour, IDamageable, IDrodObject
{
    [SerializeField] private string enemyname;
    [SerializeField] private int life = 10;
    [SerializeField] private int level = 1;


    public string Name => enemyname;
    public int Level => level;
    public int Life => life;

    public Enemy(string name, int live, int level)
    {
        this.name = name;
        this.life = live;
        this.level = level;
    }

    public void SetLife(int newLife) => life = Mathf.Max(0, newLife);
    public void SetLevel(int newLevel) => level = Mathf.Max(1, newLevel);


    public abstract void SpecialAbility();

    protected void ShowStatus()
    {
        Debug.Log("el : " + Name + "vida: " + Life + "nivel: " + Level);
    }

    public void TakeDamage(int damage)
    {
        life -= damage;

        if (life < 0)
        {
            Morir();
        }
    }

    private void Morir()
    {
        Debug.Log(Name + " ha muerto.");
        DropearItem();
        Destroy(gameObject);
    }

    protected Items itemADropear;
    public Items DropearItem()
    {
        if (itemADropear != null)
            return itemADropear;
       
        return new LifePotion("Pocion pequeña"," cura un poco de vida", 2);
       
    }
}