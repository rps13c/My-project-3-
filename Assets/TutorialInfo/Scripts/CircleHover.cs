using UnityEngine;

public class HoverInCircle : MonoBehaviour
{
    public float radius = 0.5f; // The radius of the circular motion
    public float speed = 2f; // Speed of rotation
    public float hoverHeight = 1f; // Vertical hover height
    public float hoverSpeed = 1f; // Speed of vertical bobbing

    private Vector3 startPosition;
    private float angle = 0f;

    void Start()
    {
        startPosition = transform.position; // Store the initial position
    }

    void Update()
    {
        // Calculate circular motion
        angle += speed * Time.deltaTime;
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;

        // Apply a slight up and down hover effect
        float y = Mathf.Sin(Time.time * hoverSpeed) * (hoverHeight * 0.1f);

        // Update position
        transform.position = startPosition + new Vector3(x, y, z);
    }
}