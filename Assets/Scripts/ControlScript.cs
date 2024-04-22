using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{

    public GameObject ControlCube;
    public GameObject Controls;
    public GameObject Starts;
    public GameObject ControlButton;
    public GameObject Title;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Control()
    {
        ControlCube.SetActive(true);
        Controls.SetActive(true);
        Starts.SetActive(false);
        ControlButton.SetActive(false);
        Title.SetActive(false);
    }
}
