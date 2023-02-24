using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // create variable for gameobject (car)
    [SerializeField]
    GameObject thingToFollow;

    // This things position(camera) should be the same as the car
    void Update()
    {
        // Set camera position to position of the car, minus 10 on the z axis to zoom out a bit
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
