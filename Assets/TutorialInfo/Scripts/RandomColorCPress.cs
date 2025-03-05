using UnityEngine;

public class ChangeColorOnKeyPress : MonoBehaviour
{
    private Renderer capsuleRenderer;

    void Start()
    {
        // Get the Renderer component from the capsule
        capsuleRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Check if the "C" key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        // Generate a random color
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        
        // Apply the new color to the material
        capsuleRenderer.material.color = randomColor;
    }
}