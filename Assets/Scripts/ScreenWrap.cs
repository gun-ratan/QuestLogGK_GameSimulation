using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void LateUpdate()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(transform.position);

        // Horizontal wrap
        if (viewPos.x > 1f)
            viewPos.x = 0f;
        else if (viewPos.x < 0f)
            viewPos.x = 1f;

        // Vertical wrap
        if (viewPos.y > 1f)
            viewPos.y = 0f;
        else if (viewPos.y < 0f)
            viewPos.y = 1f;

        Vector3 newPos = cam.ViewportToWorldPoint(viewPos);
        newPos.z = 0f;

        transform.position = newPos;
    }
}