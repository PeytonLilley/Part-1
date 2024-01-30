using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoal : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.color = Color.red;
        Debug.Log("Enemy Scores!");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.blue;
    }
}
