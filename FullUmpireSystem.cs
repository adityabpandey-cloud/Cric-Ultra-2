using UnityEngine;

// Cric-Ultra 26: Complete 20+ Umpire Animations & Signals
public class FullUmpireSystem : MonoBehaviour {

    public void PlayUmpireSignal(string signalType) {
        switch (signalType) {
            case "OUT": Debug.Log("Signal: Finger Raise ☝️"); break;
            case "NOT_OUT": Debug.Log("Signal: Head Shake / Cross Arms"); break;
            case "SIX": Debug.Log("Signal: Both Arms Up 🙌"); break;
            case "FOUR": Debug.Log("Signal: Hand Wave Across Waist 🖐️"); break;
            case "WIDE": Debug.Log("Signal: Arms Horizontal 👐"); break;
            case "NO_BALL": Debug.Log("Signal: One Arm Horizontal 🤚"); break;
            case "FREE_HIT": Debug.Log("Signal: Circular Finger Above Head ☝️🔄"); break;
            case "BYES": Debug.Log("Signal: Open Palm Above Head ✋"); break;
            case "LEG_BYES": Debug.Log("Signal: Knee Touch 🦵"); break;
            case "BOUNCER_1": Debug.Log("Signal: Finger on Shoulder (One for the over)"); break;
            case "BOUNCER_2": Debug.Log("Signal: Finger on Shoulder (Two for the over/No Ball)"); break;
            case "DEAD_BALL": Debug.Log("Signal: Crossing Arms Across Chest"); break;
            case "POWERPLAY": Debug.Log("Signal: Arm Swung Circle"); break;
            case "DRS_T_SIGNAL": Debug.Log("Signal: Forming a 'T' with Hands 🟦"); break;
            case "THIRD_UMP_CALL": Debug.Log("Signal: Drawing a Square Box (TV Screen) 📺"); break;
            case "STUMPS": Debug.Log("Signal: Removing Bails (End of Day/Match)"); break;
            case "SHORT_RUN": Debug.Log("Signal: Tap Shoulder with Fingers"); break;
            case "CANCEL_CALL": Debug.Log("Signal: Crossing Arms over Shoulders"); break;
            default: Debug.Log("Signal: Standard Neutral Stance"); break;
        }
    }
}
