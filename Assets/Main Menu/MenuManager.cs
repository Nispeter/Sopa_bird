using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator transitionAnim;
    public GameObject Canvas;
    void Start()
    {
        Time.timeScale = 1;
        transitionAnim.SetTrigger("START");
    }
 
    void Update()
    {
        transitionAnim.SetTrigger("IDLE");
    }

    IEnumerator LoadSceneA()
    {
        transitionAnim.SetTrigger("END");
        yield return new WaitForSeconds(1.5f);
        Time.timeScale = 1;
    }

    public void PlayGame()
    {
        
        StartCoroutine(LoadSceneA());
        SceneManager.LoadScene(1);
    }

    public void GoOptions()
    {
        StartCoroutine(LoadSceneA());
        SceneManager.LoadScene(2);
    }

    public void GoQuit()
    {
        Application.Quit();
        Debug.Log("Game is Exiting");
    }
}
