using UnityEngine;

public class EnemeyHP : MonoBehaviour
{
    public float hp = 1000f;
    public GameObject hitEffect;
    public int enemiesKilled;
    public 

    // Start is called before the first frame update
    void Start()
    {
        enemiesKilled = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            GameObject.FindWithTag("GameController").GetComponent<GameController>().enemiesKilled+=1;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        int ranAudio= Random.Range(0,2);

        if (other.tag == "SwordSlash")
        {
            //take damage
            TakeDamage(150);
            GameObject hit = Instantiate(hitEffect, new Vector3(transform.position.x, transform.position.y, transform.position.z - 5), transform.rotation);
            if (ranAudio == 1)
            {
                FindObjectOfType<AudioManager>().Play("EnemyPain");
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("EnemyPain2");
            }
        }

        if (other.CompareTag("bullet"))
        {
            Destroy(other.gameObject);
            TakeDamage(100);
            if (ranAudio == 1) {
                FindObjectOfType<AudioManager>().Play("EnemyPain");
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("EnemyPain2");
            }
            GameObject hit = Instantiate(hitEffect, new Vector3(transform.position.x, transform.position.y, transform.position.z - 5), transform.rotation);
        }
    }

    void TakeDamage(float damage)
    {
        hp = hp - damage;
    }
}
