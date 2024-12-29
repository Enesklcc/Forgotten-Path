using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    

    //health
    public int enemyHealth = 20;
    public GameObject TheEnemy;


    public void DamageEnemy(int DamageAmount)
    {
        enemyHealth -= DamageAmount;
        if (enemyHealth <= 0)
        {

            Destroy(this.gameObject);

        }
    }
 
}
