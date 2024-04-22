using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawn : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        //Get the angle between the points
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            FindObjectOfType<AudioManager>().Play("Shooting");
            GameObject bulletSpawned = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletSpawned.GetComponent<Rigidbody>().AddForce(gameObject.transform.up * 25f, ForceMode.Impulse);
        }
    }
}
