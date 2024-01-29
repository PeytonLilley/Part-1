using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 movement;
    public Rigidbody2D rigidbody;
    public float force = 5f;
    public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxis("Vertical");
        
    }

    void FixedUpdate()
    {
        float rotation = Input.GetAxis("Horizontal");
        rigidbody.AddForce(movement * force * Time.deltaTime);
        transform.Rotate(0, 0, rotation * rotationSpeed * Time.deltaTime);
    }
}
