using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushDestroy : MonoBehaviour
{

    public GameObject hitEffect;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            GameObject hit = Instantiate(hitEffect, new Vector3(transform.position.x, transform.position.y, transform.position.z - 5), transform.rotation);
        }
    }

}
