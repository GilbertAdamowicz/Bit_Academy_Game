using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartScreen : MonoBehaviour
{
    public Text scoreText; 

    void Start()
    {
        // Aangezien 'score' static is, behoudt het zijn waarde tussen scènes
        scoreText.text = "Score: " + ScoreManager.score;
    }

    public void RestartGame()
    {
        // Reset de score voor een nieuwe spelronde
        ScoreManager.score = 0;

        SceneManager.LoadScene("GameScene");
    }
}