using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement, Space.Self);

        // Rotation
        if (Input.GetMouseButton(0)) // Right mouse button
        {
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float mouseY = -Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, mouseX, Space.World);
            transform.Rotate(Vector3.right, mouseY, Space.Self);
        }
    }
}
