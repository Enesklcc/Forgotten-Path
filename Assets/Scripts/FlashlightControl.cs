using UnityEngine;
using UnityEngine.UI;

public class FlashlightControl : MonoBehaviour
{
    [SerializeField] private Light spotLight;
    private bool isOpen = true;
    private bool canOpen = true;

    [SerializeField] private float batteryHealth = 5f;
    [SerializeField] private int batteryCount = 2;

    [SerializeField] private Text batteryCountText;

    void Start()
    {
        UpdateBatteryText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (canOpen)
            {
                ToggleLight();
            }
        }
        if (isOpen)
        {
            batteryHealth -= Time.deltaTime;
        }
        if (batteryHealth <= 0)
        {
            if (batteryCount > 0)
            {
                batteryHealth = 5;
                batteryCount--;
                UpdateBatteryText();
                return;
            }

            if (isOpen)
            {
                ToggleLight();
            }
            batteryHealth = 0;
            canOpen = false;
        }
    }
    private void ToggleLight()
    {
        isOpen = !isOpen;
        spotLight.enabled = isOpen;
    }
    public void IncreaseBatteryCount()
    {
        batteryCount++;
        UpdateBatteryText();
    }
    private void UpdateBatteryText()
    {
        if (batteryCountText != null)
        {
            batteryCountText.text = "Batteries: " + batteryCount.ToString(); 
        }
    }
}