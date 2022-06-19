using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Animator transitionAnim;
    public GameObject Canvas;
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
    }
    public void PlayGame()
    {
          
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }
    public void GoOptions()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 0;
    }
    public void GoQuit()
    {
        Application.Quit();
        Debug.Log("Game is Exiting");
    }
}
