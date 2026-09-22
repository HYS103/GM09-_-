using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float rotateSpeed = 5f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseX * rotateSpeed, 0);
    }
}
