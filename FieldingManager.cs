using UnityEngine;
using System.Collections.Generic;

public class FieldingManager : MonoBehaviour {
    // List of standard positions (Slips, Point, Mid-off etc)
    public void SetFielding(string presetType) {
        if (presetType == "Attacking") {
            Debug.Log("Cric-Ultra: Setting Slip Cordon for Pace Bowler!");
        } else if (presetType == "Defensive") {
            Debug.Log("Cric-Ultra: Spreading fielders to the Boundary!");
        }
    }
}
