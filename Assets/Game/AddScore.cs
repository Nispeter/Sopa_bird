using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public Text highScore;
    public Text scoretext;
    public static int score = 0;

    void start ()
    {

        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        score = 0;
    }

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        // PlayerPrefs.SetInt("HighScore", score);
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score ++;
        //score.text = number.ToString();
        PlayerPrefs.SetInt("HighScore", score);
    }
    
}
