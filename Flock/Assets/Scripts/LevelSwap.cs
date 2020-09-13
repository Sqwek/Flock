using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwap : MonoBehaviour
{
    public int levelNum;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("dskjsdj");
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(levelNum);
        }
    }
        //void OntriggerEnter2D(Collider2D other)
    //{
        //if (other.CompareTag("player"))
        //{
            //SceneManager.LoadScene(levelNumber);
        //}
    //}
}
