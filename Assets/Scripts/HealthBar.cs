using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private RectTransform healthBarTransform;
    public float currentHealth;
    private float maxHealth = 100f;
    PlayerHealth player;

    void Start()
    {
        healthBarTransform = GetComponent<RectTransform>();
        player = FindAnyObjectByType<PlayerHealth>();

        healthBarTransform.pivot = new Vector2(0, 0.5f);
    }

    void Update()
    {
        currentHealth = Mathf.Max(player.health, 0);

        float healthRatio = currentHealth / maxHealth;

        healthBarTransform.localScale = new Vector3(healthRatio, 1, 1);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
    }
}