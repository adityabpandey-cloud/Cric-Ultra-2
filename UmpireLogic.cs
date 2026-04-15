using UnityEngine;

public class UmpireLogic : MonoBehaviour {
    // Pro-Level LBW & DRS Logic
    public bool checkLBW(Vector3 ballImpact, Vector3 stumpPos) {
        float distance = Vector3.Distance(ballImpact, stumpPos);
        if (distance < 0.2f) { // Real-time trajectory check
            Debug.Log("Umpire: OUT! ☝️");
            return true;
        }
        return false;
    }
}
