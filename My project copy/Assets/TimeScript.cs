using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Toegevoegd voor scene management

public class TimerScript : MonoBehaviour
{
    public float timeRemaining = 30;
    public Text timeText;

    // Voeg een publieke variabele toe om de naam van je score-scherm scène bij te houden
    public string RestartScreen = "Start_Screen";

    private void Start()
    {
    }

    private void Update()
    {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");

                timeRemaining = 0;

                // Verander naar de score-scherm scène
                SceneManager.LoadScene(RestartScreen);
            }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}", seconds);
    }
}
