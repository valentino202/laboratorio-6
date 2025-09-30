using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
   Rigidbody2D Rigidbody2D;
   [SerializeField] float speed;
     
   void Start()
   {
        Rigidbody2D = GetComponent<Rigidbody2D>(); 
   }


    void Update()

    {
        Vector2 caminar = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            caminar += Vector2.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            caminar += Vector2.right;
        }

        if (Input.GetKey(KeyCode.W))
        {
            caminar += Vector2.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            caminar += Vector2.down;
        }

        caminar = caminar.normalized; 

        Rigidbody2D.linearVelocity = caminar * speed;
    }
    
}
