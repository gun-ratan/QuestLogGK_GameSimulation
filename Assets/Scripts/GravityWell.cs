using UnityEngine;

public class GravityWell : MonoBehaviour
{
    public float force = 5f;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 direction = (transform.position - other.transform.position).normalized;
                rb.AddForce(direction * force);
            }
        }
    }
}