using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float speed;
    private Transform target;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        rb.velocity += direction * speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Foe")
        {
            Destroy(gameObject);
        }
    }
}
