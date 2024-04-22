using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement2D : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent agent;
    public float proximity;

    public float attackCoolDown = 1;

    [SerializeField] GameObject mainPlayer;
    float distance = 5;

    public Animation anim;
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
        //distance = Mathf.Abs(Vector2.Distance(gameObject.transform.position, mainPlayer.transform.position));
        //Debug.Log("distance: "+distance);
        FollowPlayer();
        LookAtPlayer();

        if (distance <= 7 & attackCoolDown <=0)
        {
            anim.Play("EnemySwordSwing");
            attackCoolDown = 1;
        }

        attackCoolDown -= Time.deltaTime;
    }

    private void LookAtPlayer()
    {

        Quaternion targetRotation = Quaternion.LookRotation
            (transform.forward,target.transform.position - transform.position);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 10 * Time.deltaTime);
        transform.GetComponentInChildren<Rigidbody2D>().SetRotation(rotation);
/*      
        Vector3 direction = target.transform.position - transform.position;
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction),50*Time.deltaTime);
        if (direction != Vector3.zero)
            transform.right = -direction;
        //transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);*/
    }

    public void FollowPlayer()
    {
        agent.SetDestination(target.position);
    }
}
