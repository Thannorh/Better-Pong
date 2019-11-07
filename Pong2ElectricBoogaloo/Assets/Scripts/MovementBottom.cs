using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBottom : MonoBehaviour
{
    public float Speed = 10;
    public float MaxRight = 10;
    public float MaxLeft = 10;
    public Vector2 StartingPosition = new Vector3(0f, -4.1f);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = (Vector2)(StartingPosition);
    }

    // Update is called once per frame
    void Update()
    {
        CheckUserInput();
    }

    void CheckUserInput()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x > MaxRight)
            {
                transform.position = new Vector3(MaxRight, transform.position.y, transform.position.y);
            }
            else
            {
                transform.position += Vector3.right * Speed;
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x < MaxLeft)
            {
                transform.position = new Vector3(MaxLeft, transform.position.y, transform.position.y);
            }
            else
            {
                transform.position += Vector3.left * Speed;
            }
        }
    }
}
