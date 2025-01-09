using UnityEngine;

public class DoorBath : Interactable
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
                door.Play("doorOpenBath");
                isOpen = true;
            }
            else
            {
                Debug.Log("kapý kilit");
            }


        }
        else
        {
            door.Play("doorCloseBath");
            isOpen = false;
        }
    }
}
