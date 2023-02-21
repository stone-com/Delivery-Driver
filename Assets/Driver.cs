using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float steerSpeed = 0.1f;

    [SerializeField]
    float moveSpeed = 0.01f;

    void Start() { }

    void Update()
    {
        // Get horizontal and veritcal key inputs, returns a value of -1 to 1. Multiply by speed variables to move and steer the car
        // Use Time.deltaTime to have it function independently of framerate variance
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
