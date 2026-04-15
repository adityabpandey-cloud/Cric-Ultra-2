using UnityEngine;

// Cric-Ultra 26: Project Ghan Chakkar
// Module: Advanced Bowling Physics (Swing & Seam)

public class BowlingEngine : MonoBehaviour
{
    public Rigidbody ballRb;
    public float swingIntensity = 0.5f; // Amount of swing in the air
    public float seamMovement = 0.2f;  // Movement after pitch contact

    void FixedUpdate()
    {
        // Real-time Swing: Applying Magnus Effect (Air Pressure)
        // Ball hawa mein curve hogi based on spin
        Vector3 swingForce = Vector3.Cross(ballRb.velocity, ballRb.angularVelocity) * swingIntensity;
        ballRb.AddForce(swingForce);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Real-time Seam: Contact with Pitch
        if (collision.gameObject.tag == "Pitch")
        {
            // Calculating Seam deflection
            Vector3 seamDirection = new Vector3(Random.Range(-seamMovement, seamMovement), 0, 0);
            ballRb.AddForce(seamDirection, ForceMode.Impulse);
            
            Debug.Log("Cric-Ultra: Ball Seamed off the pitch!");
        }
    }
}
