using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    float sinCenterY;
    float moveSpeed;
    [SerializeField] float MinMoveSpeed = 5;
    [SerializeField] float MaxmoveSpeed = 5;
    float waveHeight;
    [SerializeField] float MinWaveHeight = 1f;
    [SerializeField] float MaxWaveHeight = 2f;
    float waveFrequency;
    [SerializeField] float MinWaveFrequency = 0.5f;
    [SerializeField] float MaxWaveFrequency = 1f;
    [SerializeField] float waveTranslate = -1;
    
    void Start()
    {
        sinCenterY = transform.position.y;

        moveSpeed = Random.Range(MinMoveSpeed, MaxmoveSpeed);

        waveHeight = Random.Range(MinWaveHeight, MaxWaveHeight);
        
        waveFrequency = Random.Range(MinWaveFrequency, MaxWaveFrequency);
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x -= moveSpeed * Time.fixedDeltaTime;
        float sin = Mathf.Sin(pos.x * waveFrequency) * waveHeight + waveTranslate;

        if(pos.x < -10)
        {
            Destroy(gameObject);
        }
        pos.y = sin + sinCenterY;
        transform.position = pos;
    }
}

