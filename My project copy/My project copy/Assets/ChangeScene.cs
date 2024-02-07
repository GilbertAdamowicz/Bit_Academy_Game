using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        // Bepaal de index van de huidige scène en voeg er één toe om de volgende te laden
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Zorg ervoor dat de volgende scène index binnen de grenzen van beschikbare scènes valt
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            // Optioneel: Laden van de eerste scène als de volgende scène index buiten bereik is
            // SceneManager.LoadScene(0);
            Debug.Log("Geen volgende scène beschikbaar. Overweeg om terug te gaan naar de hoofdmenu scène of de game te beëindigen.");
        }
    }
}
