using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float moveSpeed = 5f;
    player Player;
    Vector2 moveDirection;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindObjectOfType<player>();
        moveDirection = (Player.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);

       // rb = GetComponent<Rigidbody2D>();
        //Vector3 direction = transform.position - player.position;
       // movement = direction;
        //rb.velocity = new Vector2 (movement)
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
