using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGoal : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.color = Color.blue;
        Debug.Log("Player Scores!");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.red;
    }
}
