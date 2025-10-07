using UnityEngine;
using static UnityEditor.Progress;

public interface IDamageable
{
    public void TakeDamage(int damage);
}
public interface IInteractable
{
    public void Interact(GameObject observer);
}

public interface IDrodObject 
{
    Items DropearItem();

}

public  interface IAttatk 
{
    public void AttacK(Enemy damage);
}

public interface IConsumible
{
    void Consumir(GameObject objet);
}

public interface IAplicarBuff
{
    void AplicarBuff(GameObject Object);
}