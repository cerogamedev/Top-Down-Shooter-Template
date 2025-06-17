using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 2f;
    public int damage = 1;

    private void OnEnable()
    {
        Invoke(nameof(DisableSelf), lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            // collision.GetComponent<EnemyHealth>().TakeDamage(damage);
            DisableSelf();
        }
    }

    void DisableSelf()
    {
        CancelInvoke();
        gameObject.SetActive(false);
    }
}
