using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        var roatateCameraInput = Input.GetAxis("RotateCamera");
        transform.Rotate(Vector3.up, roatateCameraInput * Time.deltaTime * rotationSpeed);
    }
}
