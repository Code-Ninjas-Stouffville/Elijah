using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GunEnemyMovement : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent agent;
    public float proximity;

    public float attackCoolDown = 1;

    [SerializeField] private GameObject mainPlayer;
    float distance = 5f;

    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = true;
        agent.updateUpAxis = false;

        mainPlayer = GameObject.FindWithTag("Player");
        target = mainPlayer.transform;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        LookAtPlayer();

        distance = Vector2.Distance(gameObject.transform.position, mainPlayer.transform.position);

        if (distance <= 20 & attackCoolDown <= 0)
        {
            //Instantiate
            GameObject bulletSpawned = Instantiate(bulletPrefab, transform.position, transform.rotation);

            bulletSpawned.GetComponent<Rigidbody>().AddForce(-gameObject.transform.right * 25f, ForceMode.Impulse);

            attackCoolDown = 3;
        }

        attackCoolDown -= Time.deltaTime;
    }

    private void LookAtPlayer()
    {
        float angle = AngleBetweenTwoPoints(this.transform.position, target.position);
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0, (angle + 360)));
    }

    public void FollowPlayer()
    {
        float distance = (target.position - transform.position).magnitude;

        agent.SetDestination(target.position);
    }
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}   