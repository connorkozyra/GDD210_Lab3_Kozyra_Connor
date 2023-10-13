using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouseMovement : MonoBehaviour
{
    public float sensitivity = 2.0f; // Adjust this value to control mouse sensitivity
    public bool invertYAxis = false; // Set this to true if you want to invert the Y-axis

    void Update()
    {
        // Get mouse movement input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Invert Y-axis if specified
        if (invertYAxis)
        {
            mouseY = -mouseY;
        }

        // Apply rotation to the camera based on mouse input
        transform.Rotate(Vector3.up, mouseX, Space.World); // Rotate around the world up axis
        transform.Rotate(Vector3.left, mouseY, Space.Self); // Rotate around the local left axis
    }
}
