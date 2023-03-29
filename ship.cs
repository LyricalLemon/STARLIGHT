using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    public HealthController PlayerHealth;
    Gun[] guns;
    // Start is called before the first frame update
    public float moveSpeed = 4;
    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;
    bool shoot;
    void Start()
    {
        guns = transform.GetComponentsInChildren<Gun>();
    }
    private void FixedUpdate() 
    {
        moveUp = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        moveDown = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        moveLeft = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        moveRight = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

        shoot = Input.GetKeyDown(KeyCode.Space);
        if (shoot)
        {
            foreach (Gun gun in guns)
            {
                gun.Shoot();
            }
        }

        Vector2 pos = transform.position;
        float moveAmount = moveSpeed * Time.fixedDeltaTime;
        Vector2 move = Vector2.zero;

        if(moveUp)
        {
            move.y += moveAmount;
        }
        if(moveDown)
        {
            move.y -= moveAmount;
        }
        if(moveLeft)
        {
            move.x -= moveAmount;
        }
        if(moveRight)
        {
            move.x  += moveAmount;
        }

        float moveMagnitude = Mathf.Sqrt(move.x * move.x + move.y * move.y);
        if (moveMagnitude > moveAmount)
        {
            float ratio = moveAmount / moveMagnitude;
            move *= ratio;
        }
    
        pos += move;

        if (pos.x <= -9f)
        {
            pos.x = -9f;
        }

        if (pos.x >= 7f)
        {
            pos.x = 7f;
        }

        if (pos.y <= -4f)
        {
            pos.y = -4f;
        }

        if (pos.y >= 3.5f)
        {
            pos.y = 3.5f;
        }

        transform.position = pos;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destructable destructable = collision.GetComponent<Destructable>();
        if(destructable != null)
        {
            Destroy(gameObject);
            Destroy(destructable.gameObject);
        }
    }
}
