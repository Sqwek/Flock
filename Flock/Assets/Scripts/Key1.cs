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
    void OnTriggerEnter(Collider enter)
    {
        if (collider.gameObject.tag == "player")
        {
            SceneManager.LoadScene(0);
        }
    }
}



