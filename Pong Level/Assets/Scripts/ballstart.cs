using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballstart : MonoBehaviour
{
    public int ballactive = 0;
    public float Speed = 0.0f;
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
        EmergencyReset();
        EmergencyPush();
    }

    void EmergencyPush()
    {
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            GetComponent<Rigidbody2D>().AddForce((Random.insideUnitCircle.normalized * Speed) / 4);
        }
    }
    void EmergencyReset()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            StartingPosition = new Vector2(0f, 0f);
            transform.position = (Vector2)(StartingPosition);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            ballactive = 0;
        }
    }
    void StartingPush()
    {
        if (Input.GetKey(KeyCode.Space) && ballactive == 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Random.insideUnitCircle.normalized * Speed);
            ballactive++;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player Goal Top" || collision.gameObject.name == "Player Goal Bottom")
        {
            StartingPosition = new Vector2(0f, 0f);
            transform.position = (Vector2)(StartingPosition);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            GetComponent<Rigidbody2D>().AddForce((Random.insideUnitCircle.normalized * Speed));
        }
    }
}
