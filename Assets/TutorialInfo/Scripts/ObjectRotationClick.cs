using UnityEngine;

public class RotateOnClick : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed of rotation
    private bool isRotating = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    isRotating = !isRotating; // Toggle rotation
                }
            }
        }

        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
