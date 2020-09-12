using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x < -14)
        {
            Destroy(gameObject);
        }
        if (rb.position.y < -10)
        {
            Destroy(gameObject);
        }
        if (rb.position.x > 14)
        {
            Destroy(gameObject);
        }
        if (rb.position.y > 11)
        {
            Destroy(gameObject);
        }
    }
}
