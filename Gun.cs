using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public bool autoShoot = false;
    public float shootInterval = 0.5f; 
    public float shootDelay = 0f;
    float shootTimer = 0f;
    float delayTimer = 0f;
    public Bullet bullet;

    void Update() 
    {
        if (autoShoot)
        {
            if(delayTimer >= shootDelay)
            {
                if(shootTimer >= shootInterval)
                {
                    Shoot();
                    shootTimer = 0;
                }
                else
                {
                    shootTimer += Time.deltaTime;
                }
            }
            else
            {
                delayTimer += Time.deltaTime;
            }
        }
    }
    public void Shoot()
    {
        GameObject go = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
    }
}
