//Author: Thomas Barrow
//Date Created: 3/27/18
//Date Modified: 4/2/18
//Modified by: Thomas Barrow

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void StartGame()
    {
            SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
