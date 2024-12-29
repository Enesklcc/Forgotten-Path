using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;
    private float maxHealth = 100f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);
    }

    void Update()
    {
        if (health <= 0)
        {
            health = 0;
            Time.timeScale = 0;
        }
    }
}