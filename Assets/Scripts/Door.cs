using UnityEngine;

public class Door : Interactable
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
                door.Play("doorOpen");
                isOpen = true;
            }
            else
            {
                Debug.Log("kap� kilit");
            }
           

        }
        else
        {
            door.Play("doorClose");
            isOpen = false;
        }
    }
}
