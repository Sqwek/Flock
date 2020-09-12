using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject[] foes;
    public float spawnrate;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnFoe", 0);
    }
    
    // Update is called once per frame
    void SpawnFoe()
    {
        if (Random.Range(0f, 2f) > 0.35f)
        {
            if (Random.Range(0f, 2f) > 0.35f)
            {
                Instantiate(foes[0], new Vector2(14f, Random.Range(8f, -4.28f)), Quaternion.identity);
            }
            else
            {
                Instantiate(foes[1], new Vector2(14f, Random.Range(8f, -4.28f)), Quaternion.identity);
            }
        }
        else
        {
            Instantiate(foes[2], new Vector2(14f, Random.Range(4.28f, -4.28f)), Quaternion.identity);
        }
        Invoke("SpawnFoe", Random.Range(0f, 2f));
    }

}
