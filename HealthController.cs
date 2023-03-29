using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int PlayerHealth = 3;
    public int numOfHearts;
    public Sprite FullHeart;
    public Sprite EmptyHeart;
    public Image[] hearts;

    private void Start() 
    {
        numOfHearts = PlayerHealth;
    }

    private void Update() 
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < PlayerHealth)
            {
                hearts[i].sprite = FullHeart;
            }
            else
            {
                hearts[i].sprite = EmptyHeart;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
