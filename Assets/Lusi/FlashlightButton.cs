using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightButton : MonoBehaviour
{
    public Light targetLight;

    void Update()
    {
        // Check if the "F" key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Toggle the enabled state of the light
            targetLight.enabled = !targetLight.enabled;
        }
    }
}
