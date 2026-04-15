using UnityEngine;

// Cric-Ultra 26: Project Ghan Chakkar
// Module: Manual Bowling Controls (Speed & Length)

public class BowlingControls : MonoBehaviour
{
    public Rigidbody ballRb;
    public float deliverySpeed; // Speed in kmph

    // Manual Control: Yorker, Bouncer, or Good Length
    public void ReleaseBall(Vector3 targetDirection, float inputSpeed)
    {
        deliverySpeed = inputSpeed; // Range: 120 - 155 kmph
        
        // Zero-Scripting: Applying real physics force based on player input
        ballRb.velocity = targetDirection * (deliverySpeed / 3.6f); 
        
        Debug.Log("Ball Released at: " + deliverySpeed + " kmph");
    }

    // Variations: Slower Ball & Leg-Cutter
    public void ApplyVariation(float spinAmount)
    {
        ballRb.angularVelocity = new Vector3(0, spinAmount, 0);
    }
}
