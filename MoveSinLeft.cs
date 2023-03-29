using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSinLeft : MonoBehaviour
{
    float sinCenterY;
    [SerializeField] float moveSpeed = 5;
    [SerializeField] float waveHeight = 1.5f;
    [SerializeField] float waveFrequency = 0.5f;
    [SerializeField] float waveTranslate = -3;
    
    void Start()
    {
        sinCenterY = transform.position.y;
    }

    private void Update()
    {
        Vector2 pos = transform.position;
        pos.x += moveSpeed * Time.fixedDeltaTime;
        float sin = Mathf.Sin(pos.x * waveFrequency) * waveHeight + waveTranslate;
        if(pos.x > 10)
        {
            Destroy(gameObject);
        }
        pos.y = sin + sinCenterY;
        transform.position = pos;
    }
}
