using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
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

        //new fix
        float angle = AngleBetweenTwoPoints(this.transform.position, target.position);
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0, (angle + 360)));
    }

    public void FollowPlayer()
    {
        agent.SetDestination(target.position);
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
