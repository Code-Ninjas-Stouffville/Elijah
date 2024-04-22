using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public Animation anim;
    public ParticleSystem ps;
    public bool hittable;
    private BoxCollider box;

    // Start is called before the first frame update
    void Start()
    {
        hittable = false;
        box = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SwordSlash();
        }
    }

    void SwordSlash()
    {
        anim.Play("Sword swing");
        ps.Play();
    }

    public void SetHittableToTrue()
    {
        hittable = true;
        box.enabled = true;
        
    }
    public void SetHittableToFalse()
    {
        hittable = false;
        box.enabled = false;
    }
    public void PlaySwordSound()
    {
        FindObjectOfType<AudioManager>().Play("SwordSlash");
    }
}
