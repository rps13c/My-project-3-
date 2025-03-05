using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 3f; // Movement speed
    public float changeDirectionTime = 2f; // Time before changing direction
    public Vector3 movementBounds = new Vector3(5f, 3f, 5f); // Area limits

    private Vector3 targetDirection;
    private float timer;

    void Start()
    {
        ChangeDirection();
    }

    void Update()
    {
        // Move the sphere in the current direction
        transform.position += targetDirection * speed * Time.deltaTime;

        // Change direction at intervals
        timer += Time.deltaTime;
        if (timer >= changeDirectionTime)
        {
            ChangeDirection();
        }

        // Keep the sphere within bounds
        KeepWithinBounds();
    }

    void ChangeDirection()
    {
        // Pick a new random direction
        targetDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f), Random.Range(-1f, 1f)).normalized;
        timer = 0f;
    }

    void KeepWithinBounds()
    {
        Vector3 pos = transform.position;

        // Constrain position within movementBounds
        pos.x = Mathf.Clamp(pos.x, -movementBounds.x, movementBounds.x);
        pos.y = Mathf.Clamp(pos.y, 0, movementBounds.y); // Keeps it above ground
        pos.z = Mathf.Clamp(pos.z, -movementBounds.z, movementBounds.z);

        transform.position = pos;
    }
}