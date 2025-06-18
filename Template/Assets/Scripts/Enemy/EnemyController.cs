using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    public float attackRange = 1.5f;
    public int maxHealth = 3;

    [SerializeField] private GameObject xpOrbPrefab;

    private Transform player;
    private Rigidbody2D rb;
    private int currentHealth;

    

    private enum EnemyState { Chase, Attack }
    private EnemyState currentState;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        currentState = EnemyState.Chase;
    }

    void FixedUpdate()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        switch (currentState)
        {
            case EnemyState.Chase:
                if (distance <= attackRange)
                {
                    currentState = EnemyState.Attack;
                }
                else
                {
                    Vector2 dir = (player.position - transform.position).normalized;
                    rb.linearVelocity = dir * speed;
                }
                break;

            case EnemyState.Attack:
                rb.linearVelocity = Vector2.zero;
                if (distance > attackRange)
                {
                    currentState = EnemyState.Chase;
                }
                break;
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(xpOrbPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


}
