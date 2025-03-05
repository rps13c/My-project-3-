using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private ScoreManager scoreManager;
    private float cylinderPenaltyCooldown = 1f; // 1-second cooldown
    private float lastCylinderHitTime = 0f;

    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>(); // Get ScoreManager reference
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            CollectCube(other);
        }
        else if (other.CompareTag("Cylinder"))
        {
            SubtractPointForCylinder();
        }
    }

    void CollectCube(Collider cube)
    {
        Debug.Log("Collided with Cube: " + cube.gameObject.name); // Debug to check collision

        scoreManager.AddPoint(); // Add point BEFORE disabling the cube
        cube.gameObject.SetActive(false); // Disable to prevent extra triggers
        Destroy(cube.gameObject, 0.1f); // Destroy after a short delay
    }

    void SubtractPointForCylinder()
    {
        if (Time.time > lastCylinderHitTime + cylinderPenaltyCooldown)
        {
            scoreManager.SubtractPoint();
            lastCylinderHitTime = Time.time; // Update cooldown timer
        }
    }
}
