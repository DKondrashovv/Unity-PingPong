using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    ScoreManager scr;
    public float speed = 30;
    void Start()
    {
        scr = FindObjectOfType<ScoreManager>();
        GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-60,60), Random.Range(-60, 60)).normalized * speed;
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="RoketLeft")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if(collision.gameObject.name=="RocketRight")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if(collision.gameObject.name=="WallRight")
        {
            scr.Plus();
            transform.position = Vector2.zero;
            GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-60, 60), Random.Range(-60, 60)).normalized * speed;

        }
        if(collision.gameObject.name=="WallLeft")
        {
            scr.Plus2();
            transform.position = Vector2.zero;
            GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-60, 60), Random.Range(-60, 60)).normalized * speed;

        }


    }
    float hitFactor(Vector2 ballPos,Vector2 racketPos,float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
}
