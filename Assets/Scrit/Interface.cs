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
    public void Object(GameObject od);
} 

public  interface Attatk 
{
    public int AttacK(int damage);
}

