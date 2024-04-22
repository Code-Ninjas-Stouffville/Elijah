using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseControls : MonoBehaviour
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

    public void CloseControl()
    {
        ControlCube.SetActive(false);
        Controls.SetActive(false);
        Starts.SetActive(true);
        ControlButton.SetActive(true);
        Title.SetActive(true);
    }
}
