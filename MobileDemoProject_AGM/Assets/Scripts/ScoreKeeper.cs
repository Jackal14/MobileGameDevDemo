using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    public int score;
    int highScore;

    private string SCORE = "HighScore";

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt(SCORE).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        highScore = score;
        if(PlayerPrefs.GetInt(SCORE) <= highScore)
        {
            PlayerPrefs.SetInt(SCORE, highScore);
        }
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt(SCORE).ToString();
    }

    public void AddPoint()
    {
        score++;
    }
}
