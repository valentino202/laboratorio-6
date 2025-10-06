using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
   Rigidbody2D _rigidbody2D;
   [SerializeField] float speed;
   Vector2 direccion;
     
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
}
