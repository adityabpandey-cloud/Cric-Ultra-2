using UnityEngine;

// Cric-Ultra 26: Project Ghan Chakkar
// Core Physics: Bat-Ball Real-Time Collision (War Thunder Style)

public class BatBallPhysics : MonoBehaviour
{
    public float batSwingSpeed = 50f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CricketBall")
        {
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            
            // Zero-Scripting: Pure Physics Contact
            Vector3 hitDirection = collision.contacts[0].normal;
            ballRb.AddForce(-hitDirection * batSwingSpeed, ForceMode.Impulse);
            
            Debug.Log("Cric-Ultra Physics: Real-time Hit!");
        }
    }
}
