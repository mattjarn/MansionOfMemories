using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
    public bool startGame = false;

	public void ChangeScenes()
    {
        if (startGame)
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void SetStartGame(bool start)
    {
        startGame = start;
    }
}
