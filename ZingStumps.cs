using UnityEngine;

// Cric-Ultra 26: Zing Stumps Glow System
public class ZingStumps : MonoBehaviour {
    public Light stumpLight; // Red Light component
    public AudioSource bailsSound; // Sound of bails falling

    void OnCollisionEnter(Collision col) {
        // Agar ball stumps ya bails se takraye
        if (col.gameObject.tag == "CricketBall") {
            stumpLight.enabled = true; // Red Light ON!
            stumpLight.intensity = 5.0f; // Extra brightness
            
            if(!bailsSound.isPlaying) bailsSound.Play();
            
            Debug.Log("ZING! Stumps Glowing Red - OUT!");
        }
    }
}
