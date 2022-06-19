using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public Text highScore;

    void Start()
    {
        // highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        score = 0;
    }


    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        // PlayerPrefs.SetInt("HighScore", score);
    }
}
