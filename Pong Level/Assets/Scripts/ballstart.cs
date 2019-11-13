using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballstart : MonoBehaviour
{
    public int ballactive = 0;
    public float XSpeed = 0.0f;
    public float YSpeed = 0.0f;
    public Vector2 StartingPosition = new Vector2(0f, -4.1f);
    // Start is called before the first frame update
    void Start()
    {
        ballactive = 0;
        transform.position = (Vector2)(StartingPosition);
    }

    // Update is called once per frame
    void Update()
    {
        StartingPush();
    }

    void StartingPush()
    {
        if (Input.GetKey(KeyCode.Space) && ballactive == 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(XSpeed, YSpeed));
            ballactive++;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player Goal Top" || collision.gameObject.name == "Player Goal Bottom")
        {
            StartingPosition = new Vector2(0f, 0f);
            transform.position = (Vector2)(StartingPosition);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(XSpeed, YSpeed));
        }
    }
}
