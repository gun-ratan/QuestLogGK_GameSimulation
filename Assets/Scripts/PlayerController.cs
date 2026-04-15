using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 200f;
    public float thrustForce = 6f;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GameObject gameOverText;
    public GameObject gravityWell;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float turn = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0f, 0f, -turn * rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * thrustForce);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bulletPrefab != null && firePoint != null)
            {
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

                if (AudioManager.Instance != null)
                {
                    AudioManager.Instance.PlayShoot();
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid"))
        {
            if (AudioManager.Instance != null)
            {
                AudioManager.Instance.PlayGameOver();
            }

            if (gameOverText != null)
                gameOverText.SetActive(true);

            if (gravityWell != null)
                gravityWell.SetActive(false);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}