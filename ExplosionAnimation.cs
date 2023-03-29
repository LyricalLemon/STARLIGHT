using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAnimation : MonoBehaviour
{
    public ParticleSystem explosion;
    public void OnTriggerEnter(Collider collision) 
    {
        if(collision.CompareTag("Player"))
        {
            explosion.Play();
        }
    } 
}
