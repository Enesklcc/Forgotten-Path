using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public float distance;
    public Transform playerTransform;
    public NavMeshAgent NavMeshAgent;
    private Animator animator;
    public GameObject player;

    private float damageRange;
    public float damageSet = 25f;
    public float minDamage;
    public float maxDamage;
    public bool randomDamage;
    public bool setDamage;

    public int enemyHealth = 20;
    public GameObject TheEnemy;
    void Start()
    {
        damageRange = Random.Range(minDamage, maxDamage);
        animator = GetComponent<Animator>();
        NavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        distance=Vector3.Distance(this.transform.position, playerTransform.position);
        if (distance<16.5)
        {
            NavMeshAgent.destination = playerTransform.position;
            if (distance<16)
            {
                animator.SetBool("isRunning", true);

                if (distance<1.51)
                {
                    animator.SetBool("isAttacking", true) ;
                }
                else
                {
                    animator.SetBool("isAttacking", false);

                }
            }
            
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && randomDamage)
        {
            player.GetComponent<PlayerHealth>().health -= damageRange;
        }
        if (other.gameObject.tag == "Player" && setDamage)
        {
            player.GetComponent<PlayerHealth>().health -= damageSet;
        }
    }
    public void DamageEnemy(int DamageAmount)
    {
        enemyHealth -= DamageAmount;
        if (enemyHealth <= 0)
        {

            Destroy(this.gameObject);

        }
    }

}
