using NUnit.Compatibility;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour, IAttatk
{
  
 [SerializeField] private int liveP;
 [SerializeField]  private int damage;
 [SerializeField]  private float attackRange;
 [SerializeField]  private LayerMask enemyLayer;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryAttack();
        }

    }

    void TryAttack()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, attackRange, enemyLayer);

        if (hit != null)
        {
            Enemy enemy = hit.GetComponent<Enemy>();
            if (enemy != null)
            {
                AttacK(enemy);
            }
        }
        else
        {
            Debug.Log(" el enemigo no esta serca");
        }

       
    }
        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackRange);
        }


        public void FixedUpdate()
        {
            _rigidbody2D.linearVelocity = direccion  * speed;
        }

    public void AttacK (Enemy damage)
    {
        Debug.Log( name + " ataca.");
        damage.TakeDamage(Damage);
    }
}
