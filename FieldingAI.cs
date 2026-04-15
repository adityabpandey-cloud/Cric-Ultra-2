using UnityEngine;

// Cric-Ultra 26: Project Ghan Chakkar
// Module: Smart Fielding AI & Ball Tracking

public class FieldingAI : MonoBehaviour
{
    public Transform cricketBall;
    public float fielderSpeed = 5.5f;
    public float throwAccuracy = 0.9f;

    void Update()
    {
        // Real-time Tracking: Fielder ball ki taraf bhagega
        float distanceToBall = Vector3.Distance(transform.position, cricketBall.position);

        if (distanceToBall > 1.5f)
        {
            // Ball ki trajectory predict karke intercept karna
            Vector3 targetDirection = (cricketBall.position - transform.position).normalized;
            transform.position += targetDirection * fielderSpeed * Time.deltaTime;
        }
        else
        {
            CatchAndThrow();
        }
    }

    void CatchAndThrow()
    {
        Debug.Log("Cric-Ultra AI: Ball Picked! Throwing to Stumps...");
        // Logic for throwing back to Keeper or Bowler
    }
}
