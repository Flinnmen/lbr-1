using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookScript : MonoBehaviour
{
    public Transform tf;
    public SpriteRenderer renderer;
    public Color standard = new Color();
    public Color orange = new Color();

    public float runSpeed = 0.25f;
    private bool arrived = false;
    
    public float velocityX = 15f;
    public float velocityY = 15f;

    private GameObject playerObject;
    private Transform player;
    private Rigidbody2D playerRb;

    private GameObject enemyObject;
    public Transform enemy;

    public GameObject rope;
    

    void Start()
    {
        //Assign player
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<Transform>();
        playerRb = playerObject.GetComponent<Rigidbody2D>();

        //Face player
        tf.up = player.position - tf.position;

        //Assign enemy
        enemyObject = GameObject.Find("HookEnemy");
        enemy = enemyObject.GetComponent<Transform>();

    }

    void Update()
    {
        if (Vector3.Distance(tf.position, enemy.position) > 6)
        {
            //Debug.Log("arrived at location");
            arrived = true;
            renderer.color = orange;
            //Face enemy (parent)
            tf.up = enemy.position - tf.position;
        }
        else
        {
            renderer.color = standard;
        }
            StartCoroutine(ExecuteAfterTime(10));
        if (!arrived) {

                    Instantiate(rope, new Vector3(tf.position.x, tf.position.y, tf.position.z + 1), Quaternion.identity);
            
                }


    }

    void FixedUpdate()
    {
        //Move towards target
        tf.position += tf.up * runSpeed;
    }

     IEnumerator ExecuteAfterTime(float time) {
                yield return new WaitForSeconds(time);
    
         }

    void OnTriggerEnter2D (Collider2D other)
    {   
        if (other.gameObject.tag == "HookEnemy" && arrived)
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Rope" && arrived)
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Player" && !arrived)
        {
            arrived = true;
            tf.up = enemy.position - tf.position;
            //Debug.Log("early return");
            hitEnemy();
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.tag == "Rope" && arrived)
        {
            Destroy(other.gameObject);
        }
    }

    void hitEnemy()
    {
        playerRb.velocity = new Vector2(velocityX, velocityY);
    }
}
