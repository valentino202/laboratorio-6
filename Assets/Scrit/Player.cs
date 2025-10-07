using NUnit.Compatibility;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour, IAttatk
{
  
    private int liveP;
    private int damage;
   Rigidbody2D _rigidbody2D;
   [SerializeField] float speed;
   Vector2 direccion;

    public int LiveP => liveP;
    public int Damage => damage;
   void Start()
   {
        _rigidbody2D = GetComponent<Rigidbody2D>(); 
   }

    void Update()

    {
           direccion = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
             direccion += Vector2.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direccion += Vector2.right;
        }

        if (Input.GetKey(KeyCode.W))
        {
            direccion += Vector2.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direccion += Vector2.down;
        }

        direccion = direccion.normalized;

    }
        public void FixedUpdate()
        {
            _rigidbody2D.linearVelocity = direccion  * speed;
        }

    public int AttacK(int damage)
    {
        throw new System.NotImplementedException();
    }
}
