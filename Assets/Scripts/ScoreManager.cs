using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void ScoreCalculator(int scoreValue)
    {
        score = scoreValue;
        scoreText.text = score.ToString();
       // print("Score: " +score);
    }
}
