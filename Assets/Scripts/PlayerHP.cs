using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int maxHealth = 500;
    public int currentHealth;
    public int HitCount;

    public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        HitCount = 0;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

        if(this.currentHealth <= 0)
        {

            SceneManager.LoadScene(3);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BatSlash")
        {
            TakeDamage(10);
            HitCount += 1;
            FindObjectOfType<AudioManager>().Play("BatHit");
        }

        if(other.tag == "EnemyBullet")
        {
            TakeDamage(50);
            HitCount += 1;
            FindObjectOfType<AudioManager>().Play("ArrowHit");
        }
    }
}
