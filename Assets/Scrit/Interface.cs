using UnityEngine;

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
   public void Drop(GameObject dropper);

}

public  interface IAttatk 
{
    public int AttacK(int damage);
}

public interface IConsumible
{
    void Consumir();
}

public interface IAplicarBuff
{
    void AplicarBuff(GameObject Object);
}