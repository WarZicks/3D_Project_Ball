using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public float movementSpeed = 10;
    public float turningSpeed = 60;

    void Update()
    {
        float horizontal = Input.GetAxis("CameraHorizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("CameraVertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}