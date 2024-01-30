using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float ballSpeedX = -10f;
    public float ballSpeedY = 5f;
    public float acceleration = 50f;
    float ballHorizontal;
    float ballVertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(ballSpeedX * Time.deltaTime, ballSpeedY * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D()
    {
        ballSpeedX = -ballSpeedX;
        ballSpeedY = -ballSpeedY;
        Vector2 force = transform.right * acceleration * ballSpeedX * Time.deltaTime;
        rigidbody2D.AddForce(force);
    }
}
