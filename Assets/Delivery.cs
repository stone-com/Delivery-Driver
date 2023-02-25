using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField]
    float destroyTime = 0.5f;

    void OnCollisionEnter2D(Collision2D other)
    {
        // Code for colliding with something (that is not a trigger)
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyTime);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered to customer!");
            hasPackage = false;
        }
    }
}
