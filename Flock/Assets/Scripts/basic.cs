using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed * Random.Range(0.15f, 1f);
        // Destroy(gameObject, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.position.x < -14)
        {
            Destroy(gameObject);
        }
        if (rb.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
