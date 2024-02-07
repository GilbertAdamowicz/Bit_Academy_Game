using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Scene : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
