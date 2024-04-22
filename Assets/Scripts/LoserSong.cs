using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoserSong : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Loser");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
