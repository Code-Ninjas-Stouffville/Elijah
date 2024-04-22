using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowHighScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TMP_Text>().text="Highest score: "+FindObjectOfType<GameController>().HighScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
