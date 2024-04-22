using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public int enemiesKilled;
    public GameObject Wave1;
    public GameObject Wave2;
    public GameObject Wave3;
    public GameObject Wave4;
    public GameObject Wave5;
    public GameObject Wave6;
    public GameObject Wave7;
    public GameObject Wave8;
    public GameObject Wave9;
    public GameObject Wave10;
    public GameObject worths;

    private GameObject currentWave;

    private float timer;
    private float delay=2;
    private bool trigger = false;

    [SerializeField]private GameObject melee;
    [SerializeField]private GameObject gunner;

    public float x;
    public float y;
    public int score = 0;
    public TMP_Text ScoreText;
    public int Hits=0;
    public int HighScore = 0;

    public bool worth = false;

    public GameObject sword;
    public GameObject gun;

    private PlayerHP HPstate;
    [SerializeField] private GameObject mainPlayer;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        mainPlayer = GameObject.FindWithTag("Player");
        HPstate=mainPlayer.GetComponent<PlayerHP>();

        worth = false;

        gun.SetActive(false);
        sword.SetActive(true);

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<PlayerHP>().HitCount!=null)
            Hits = FindObjectOfType<PlayerHP>().HitCount;
        score = (enemiesKilled*10) - (Hits*2);
        ScoreText.text = "Score:" + score;

        if(enemiesKilled == 0&& trigger == false)
        {
            trigger = true; 
            currentWave = Wave1;
            StartWave();
            Invoke("EndWave",2);

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if (enemiesKilled == 10 && trigger == true)
        {
            trigger = false;
            currentWave = Wave2;
            StartWave();
            Invoke("EndWave", 2);

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if (enemiesKilled == 20 && trigger == false)
        {
            trigger = true;
            currentWave = Wave3;
            StartWave();
            Invoke("EndWave", 2);

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if (enemiesKilled == 30 && trigger == true)
        {
            HPstate.currentHealth = HPstate.maxHealth;
            trigger = false;
            currentWave = Wave4;
            StartWave();
            Invoke("EndWave", 2);

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

        for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if (enemiesKilled == 40 && trigger == false)
        {
            trigger = true;
            currentWave = Wave5;
            StartWave();
            Invoke("EndWave", 2);
            worths.SetActive(true);
            Invoke("GunUnworth", 2);
            worth = true;

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }

        }

        if (enemiesKilled == 50 && trigger == true)
        {
            trigger = false;
            currentWave = Wave6;
            StartWave();
            Invoke("EndWave", 2);

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if (enemiesKilled == 60 && trigger == false)
        {
            trigger = true;
            currentWave = Wave7;
            StartWave();
            Invoke("EndWave", 2);

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if (enemiesKilled == 70 && trigger == true)
        {
            trigger = false;
            currentWave = Wave8;
            StartWave();
            Invoke("EndWave", 2);
            HPstate.currentHealth = HPstate.maxHealth/2;

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if (enemiesKilled == 80 && trigger == false)
        {
            trigger = true;
            currentWave = Wave9;
            StartWave();
            Invoke("EndWave", 2);

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if (enemiesKilled == 90 && trigger == true)
        {
            trigger = false;
            currentWave = Wave10;
            StartWave();
            Invoke("EndWave", 2);

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(melee, new Vector3(x, y, 0), Quaternion.identity);
            }

            for (int i = 0; i < 5; i++)
            {
                x = Random.Range(-40f, 27f);
                y = Random.Range(-56f, 12f);
                Instantiate(gunner, new Vector3(x, y, 0), Quaternion.identity);
            }
        }

        if(enemiesKilled == 100)
        {
            NewHighScore();
            SceneManager.LoadScene(2);
            
        }

        if (Input.GetKeyDown("1"))
        {
            sword.SetActive(true);
            gun.SetActive(false);
        }

        if (worth == true && Input.GetKeyDown("2"))
        {
            gun.SetActive(true);
            sword.SetActive(false);
        }

    }

    public void StartWave()
    {
        currentWave.SetActive(true);
    }

    public void EndWave()
    {
        currentWave.SetActive(false);
    }

    public void GunWorth()
    {
        worths.SetActive(true);
    }

    public void GunUnworth()
    {
        worths.SetActive(false);
    }

    public void NewHighScore()
    {
        if (HighScore < score)
        {
            HighScore = score;
        }
    }
}
