using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    int score = 0;
    Text scoreText;
    private void Awake() 
    {
        scoreText = GameObject.Find("Scoreboard").GetComponent<Text>();
    }
    public void AddScore(int amountToAdd)
    {
        score += amountToAdd;
        scoreText.text = score.ToString();
    }    
}
