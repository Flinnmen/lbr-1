using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionSpawn : MonoBehaviour
{
    public GameObject potion;
    public Transform tf;

    private bool ready = true;
    public int spawnDelay = 7;
    public float offset = 2f;

    void Update()
    {
        if (ready)
        {
            ready = false;
            StartCoroutine(delay());

            Instantiate(potion, new Vector3(tf.position.x, tf.position.y + offset, 0), Quaternion.identity);
        }
    }
    IEnumerator delay() 
    {
        yield return new WaitForSeconds (spawnDelay);
        ready = true;
    }
}
