using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 2f;
    public GameObject asteroidPrefab;
    public int size = 2; // 2 = big, 1 = small
    public GameObject explosionPrefab;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 dir = Random.insideUnitCircle.normalized;
        rb.linearVelocity = dir * speed;
    }

    public void Break()
    {
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            ParticleSystem ps = explosion.GetComponent<ParticleSystem>();

            if (ps != null)
            {
                ps.Play();
            }

            Destroy(explosion, 1f);
        }

        if (size > 1)
        {
            Vector3 offset1 = new Vector3(0.5f, 0.5f, 0f);
            Vector3 offset2 = new Vector3(-0.5f, -0.5f, 0f);

            GameObject newAst1 = Instantiate(asteroidPrefab, transform.position + offset1, Quaternion.identity);
            GameObject newAst2 = Instantiate(asteroidPrefab, transform.position + offset2, Quaternion.identity);

            Asteroid ast1 = newAst1.GetComponent<Asteroid>();
            Asteroid ast2 = newAst2.GetComponent<Asteroid>();

            if (ast1 != null)
            {
                ast1.size = 1;
                ast1.explosionPrefab = explosionPrefab;
            }

            if (ast2 != null)
            {
                ast2.size = 1;
                ast2.explosionPrefab = explosionPrefab;
            }

            newAst1.transform.localScale = transform.localScale * 0.5f;
            newAst2.transform.localScale = transform.localScale * 0.5f;
        }

        Destroy(gameObject);
    }
}