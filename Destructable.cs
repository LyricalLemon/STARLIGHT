using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class Destructable : MonoBehaviour
{
    public int EnemyScoreValue = 100;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Bullet bullet = collision.GetComponent<Bullet>();
        if (bullet != null)
        {
            if(!bullet.isEnemy)
            {
                Level.instance.AddScore(EnemyScoreValue);
                Destroy(gameObject);
                Destroy(bullet.gameObject);
            }
        }
    }
}
