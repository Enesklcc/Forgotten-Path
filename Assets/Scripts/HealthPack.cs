using UnityEngine;

public class HealthPack : Collectable
{
    [SerializeField] private float healthIncrease = 25f;
    
    public override void Collect()
    {
        base.Collect();

        PlayerHealth playerHealth = FindAnyObjectByType<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.health += healthIncrease;
        }
        
    }
}