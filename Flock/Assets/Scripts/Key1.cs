using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key1 : MonoBehaviour
{
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "player")
        {
            SceneManager.LoadScene(0);
        }
        //if (collision.gameObject.tag == "key1")
        {
            SceneManager.LoadScene(2);
        }
    }
}



