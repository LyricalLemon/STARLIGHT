using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level : MonoBehaviour
{
    int score = 0;
    TextMeshProUGUI scoreText;
    public static Level instance;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
            scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        }
    }

    public void AddScore(int scoreAmount)
    {
        score += scoreAmount;
        scoreText.text = score.ToString();
    }
}
