using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int EnemyDamage = 1;   
    [SerializeField] private HealthController healthController;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Bullet bullet = collision.GetComponent<Bullet>();
        if(collision.CompareTag("EnemyBullet"))
        {
            healthController.PlayerHealth -= EnemyDamage;
            healthController.UpdateHealth();
        }
        if(healthController.PlayerHealth <= 0)
        {
            Destroy(gameObject); //player
            SceneManager.LoadScene("GameOver");
        }
        if(collision.CompareTag("Enemy"))
        {
            Destroy(gameObject); //player
            SceneManager.LoadScene("GameOver");
        }
    }  
}
