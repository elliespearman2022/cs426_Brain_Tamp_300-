using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehavior : MonoBehaviour
{

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround;
     
    public LayerMask whatIsPlayer;
    
    /*
    We don't need this yet, but it can be changed to temp
    public float health;
    */
    
    // Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    // We don't need this just yet
    // Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    // Might not need this 
    public GameObject projectile;

    // States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake(){
        player = GameObject.Find("Ch36").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update(){
        // Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if(!playerInSightRange && !playerInAttackRange) Patrolling();
        if(playerInSightRange  && !playerInAttackRange) ChasePlayer();
        if(playerInAttackRange && playerInSightRange) AttackPlayer();
    }

    private void Patrolling(){
        if(!walkPointSet) SearchWalkPoint();
        if(walkPointSet){
            agent.SetDestination(walkPoint);
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        // When we reach the walk point
        if(distanceToWalkPoint.magnitude < 1f){
            walkPointSet = false;
        }
    }

    private void SearchWalkPoint(){
        // Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        
        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if(Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround)){
            walkPointSet = true;
        }
    
    }

    private void ChasePlayer(){
        agent.SetDestination(player.position);
    }

    private void AttackPlayer(){
        // Make sure the enemy doesn't move
        agent.SetDestination(transform.position);
        transform.LookAt(player);
        if(!alreadyAttacked){
            // Attack Code
            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb. AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb. AddForce(transform.up * 8f, ForceMode.Impulse);


            //
            alreadyAttacked = true;
            //Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    /* 
    This is not needed


    public void TakeDamage(int Damage){
        health -=damage;
        if(health <=0){
            Invoke(nameof)(DestroyEnemy), .
        }
    }

    public void DestroyEnemy(){
        Destroy(gameObject);
    }

    */
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
}
