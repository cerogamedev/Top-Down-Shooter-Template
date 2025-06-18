using UnityEngine;

public class XPOrb : MonoBehaviour
{
    public int xpAmount = 10;
    public float moveSpeed = 5f;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player == null) return;

        Vector2 dir = (player.position - transform.position).normalized;
        transform.position += (Vector3)dir * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats.Instance.AddXP(xpAmount);
            Destroy(gameObject);
        }
    }
}
