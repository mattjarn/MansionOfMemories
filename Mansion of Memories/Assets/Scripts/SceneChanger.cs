//Author: Thomas Barrow
//Date Created: 3/27/18
//Date Modified: 4/2/18
//Modified by: Thomas Barrow

using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour {
    //Exposed easily reached methods for starting/restarting and ending the game
    public void StartGame()
    {
            SceneManager.LoadScene("Main");
    }
    //Exposed easily reached methods for starting/restarting and ending the game
    public void QuitGame()
    {
        Application.Quit();
    }

}
