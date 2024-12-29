using UnityEngine;

public class Battery : Collectable
{
    [SerializeField] private FlashlightControl flashLight;
    private void Start()
    {
        flashLight = GameObject.FindAnyObjectByType<FlashlightControl>();
    }
    public override void Collect()
    {
        base.Collect();
        if (flashLight)
        {
            flashLight.IncreaseBatteryCount();
        }
    }
}
