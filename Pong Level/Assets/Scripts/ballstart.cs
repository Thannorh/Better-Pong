using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballstart : MonoBehaviour
{
    public float XSpeed = 0.0f;
    public float YSpeed = 0.0f;
    public Vector2 StartingPosition = new Vector3(0f, -4.1f);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = (Vector2)(StartingPosition);
    }

    // Update is called once per frame
    void Update()
    {
        StartingPush();
    }

    void StartingPush()
    {
        if (Input.GetKey("space"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(XSpeed, YSpeed));
        }
    }
}
