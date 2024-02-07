using UnityEngine;

public class CursorLightController : MonoBehaviour
{
    public float lightDistance = 10f;

    void Update()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; // Ensure the light is at the same Z position as the camera

        // Set the position of the CursorLight GameObject to follow the mouse
        transform.position = mousePos;

        // Optionally, adjust the light intensity based on the distance from the cursor
        float intensity = Mathf.Lerp(0f, 1f, Mathf.InverseLerp(0f, lightDistance, Vector3.Distance(transform.position, Camera.main.transform.position)));
        GetComponent<Light>().intensity = intensity;
    }
}
