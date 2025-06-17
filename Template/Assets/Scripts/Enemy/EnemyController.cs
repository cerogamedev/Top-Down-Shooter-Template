using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    public float attackRange = 1.5f;
    public int maxHealth = 3;

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

    void Update()
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
                // Buraya attack animasyonu vs. gelir
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
        // XP düşürme vs burada
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage(1); // Damage'ı bullet'tan da çekebilirsin
            collision.gameObject.SetActive(false);
        }
    }
}
