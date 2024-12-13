using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is tagged as "Ball"
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Destroy the target object
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
