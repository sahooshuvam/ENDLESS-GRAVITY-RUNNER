using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    private void Start()
    {
       //PlayerPrefs.GetInt("Score");
        Debug.Log(PlayerPrefs.GetInt("Score"));
    }

    public void ScoreCalculator(int scoreValue)
    {
        score = scoreValue;
        PlayerPrefs.SetInt("Score",score);
        scoreText.text = score.ToString();
       // print("Score: " +score);
    }
}
