using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
 
    public GameObject GameOverCanvas;

    public void start ()
    {

        Time.timeScale = 1;
    }
    void update ()
    {

    }
    public void GameOver ()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
  
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 0;
    }
}
