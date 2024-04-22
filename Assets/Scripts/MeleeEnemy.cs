using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D enemyrb;
    public Animator anim;

    public float speed = 20f;
    public int damage = 10;

    public Vector2 dir;
    public Transform Player;
   
    public bool inRange = false;
    public bool limit = false;

    // Start is called before the first frame update
    void Start()
    {
        enemyrb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Speed: " + speed);
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        enemyrb.rotation = angle;
        direction.Normalize();
        dir = direction;

        float distance = (Player.position - transform.position).magnitude;
        
        if(distance < 3f)
        {
            inRange = false;
            limit = false;
            speed = 0.0f;
        } else
        {
            if (inRange == true) {
                limit = true;
                speed = 5.0f;
            }
        }
    }

    void moveCharacter(Vector2 direction)
    {
        enemyrb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && limit == false)
        {
            inRange = true;
            speed = 5.0f;
            Debug.Log("Entering");
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inRange = false;
            speed = 0.0f;
            Debug.Log("Leaving");
        }
    }

    void FixedUpdate()
    {
        if (inRange == true)
        {
            Vector3 direction = Player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            enemyrb.rotation = angle;

            enemyrb.velocity = (Vector2)direction.normalized * speed;

        }
    }
}
