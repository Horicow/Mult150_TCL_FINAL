using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    public float startSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(0, 0, startSpeed); // Lock movement in the x-axis
    }

    // Handle collision to make the object bounce
    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        Vector3 normal = collision.contacts[0].normal; 

        
        Vector3 newVelocity = Vector3.Reflect(rigidBody.velocity, normal);
        newVelocity.x = 0; // Lock x-axis movement

        rigidBody.velocity = newVelocity.normalized * startSpeed;
    }
}
