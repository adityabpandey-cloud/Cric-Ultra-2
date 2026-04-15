using UnityEngine;
using UnityEngine.SceneManagement;

// Cric-Ultra 26: Home Page Controller
public class MenuManager : MonoBehaviour
{
    // Jab aap IPL 2026 button dabaoge
    public void PlayIPL()
    {
        Debug.Log("Starting IPL 2026 Mode... Loading Teams!");
        SceneManager.LoadScene("IPL_Match");
    }

    // Jab aap T20 World Cup button dabaoge
    public void PlayWorldCup()
    {
        Debug.Log("Starting T20 World Cup... India vs New Zealand!");
        SceneManager.LoadScene("WC_Match");
    }

    // Settings kholne ke liye
    public void OpenSettings()
    {
        Debug.Log("Opening Graphics & Control Settings");
    }
}
