using UnityEngine;

public class CubeDisappearOnCollision : MonoBehaviour
{
    // This method is called when a trigger collider enters the cube's collider
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}