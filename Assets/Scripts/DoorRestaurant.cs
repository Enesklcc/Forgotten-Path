using UnityEngine;

public class DoorRestaurant : Interactable
{
    public Animation door;
    public bool isOpen;
    public bool isLocked;
    public override void Interact()
    {
        base.Interact();
        if (!isOpen)
        {
            if (!isLocked)
            {
                door.Play("doorOpenRestaurant");
                isOpen = true;
            }
            else
            {
                Debug.Log("kapý kilit");
            }


        }
        else
        {
            door.Play("doorCloseRestaurant");
            isOpen = false;
        }
    }
}
