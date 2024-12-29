using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; 
    public int damage = 10;   

    void Start()
    {
        Destroy(gameObject, 5f); 
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        EnemyAI enemy = other.GetComponent<EnemyAI>();
        if (enemy != null)
        {
            enemy.DamageEnemy(damage);
        }

        Destroy(gameObject);
    }
}