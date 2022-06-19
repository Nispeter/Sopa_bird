using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsManager : MonoBehaviour
{

    public GameObject OptionsCanvas;

    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 0;
    }
}
