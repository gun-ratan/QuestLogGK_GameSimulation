using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject player;
    public GameObject gravityWell;

    void Update()
    {
        if (player != null && GameObject.FindGameObjectsWithTag("Asteroid").Length == 0)
        {
            if (winText != null)
                winText.SetActive(true);

            if (gravityWell != null)
                gravityWell.SetActive(false);
        }
    }
}