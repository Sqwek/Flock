using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private Vector3 target;
    public int Key1Level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            transform.position = target;
            Vector2 playerpos = new Vector2(transform.position.x, transform.position.y);
            playerpos.x = Mathf.Clamp(transform.position.x, -13.5f, 13.5f);
            playerpos.y = Mathf.Clamp(transform.position.y, -7f, 7f);
            transform.position = playerpos;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Foe")
        {
            SceneManager.LoadScene(0);
        }
        else if (collision.gameObject.tag == "Key1")
        {
            SceneManager.LoadScene(2);
            Debug.Log(2);
        }
        //if (collision.gameObject.tag == "key1")
        //{
        //SceneManager.LoadScene(2);
        //}
    }
}
