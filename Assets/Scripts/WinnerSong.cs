using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerSong : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Winner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
