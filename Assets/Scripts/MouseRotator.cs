using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    public float rotationSpeed = 1000f;  // Speed of rotation

    private void OnMouseDrag()
    {
        float xRotation = Input.GetAxis("Mouse X") * -rotationSpeed * Time.deltaTime;
        transform.Rotate(0, xRotation, 0, Space.Self);
    }
}
