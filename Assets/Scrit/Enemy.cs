using UnityEngine;
using static UnityEditor.Progress;

public abstract class Enemy : MonoBehaviour, IDamageable, IDrodObject
{
    [SerializeField] private GameObject lifePotionPrefab;
    [SerializeField] private GameObject elixirOfSpeedPrefab;
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
        LifePotion pocionvida = new LifePotion("Poción pequeña", "Cura un poco de vida", 5);
        ElixirOfSpeed pocion_de_velocidad = new ElixirOfSpeed("Elixir de Velocidad", "Aumenta la velocidad por un tiempo", 5, 10);

        int random = Random.Range(0, 2);

        Items itemDropeado;


        if (random == 0)
        {
            itemDropeado = pocionvida;
            if (lifePotionPrefab != null)
                Instantiate(lifePotionPrefab, transform.position, Quaternion.identity);
            else
                Debug.LogWarning("Falta asignar el prefab de la Poción de Vida");
        }
        else
        {
            itemDropeado = pocion_de_velocidad;
            if (elixirOfSpeedPrefab != null)
                Instantiate(elixirOfSpeedPrefab, transform.position, Quaternion.identity);
            else
                Debug.LogWarning("Falta asignar el prefab del Elixir de Velocidad");
        }

        Debug.Log("Objeto dropeado: " + itemDropeado.Name);

        return itemDropeado;
    }
}