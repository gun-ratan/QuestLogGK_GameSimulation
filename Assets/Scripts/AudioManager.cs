using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip shootClip;
    public AudioClip gameOverClip;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayShoot()
    {
        if (shootClip != null)
        {
            sfxSource.PlayOneShot(shootClip);
        }
    }

    public void PlayGameOver()
    {
        if (gameOverClip != null)
        {
            sfxSource.PlayOneShot(gameOverClip);
        }
    }
}