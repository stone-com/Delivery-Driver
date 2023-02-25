using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField]
    Color32 hasPackageColor = new Color32(241, 46, 0, 255);

    [SerializeField]
    Color32 noPackageColor = new Color32(1, 1, 1, 255);

    [SerializeField]
    float destroyTime = 0.5f;

    // Initialize variable for spriteRenderer
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyTime);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered to customer!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
