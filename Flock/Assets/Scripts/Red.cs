using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float movespeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // player = GameObject.FindGameObjectsWithTag("player");
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.velocity += direction * movespeed * Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Foe")
        {
            Destroy(gameObject);
        }
    }
}
