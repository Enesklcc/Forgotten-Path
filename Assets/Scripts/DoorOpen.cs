using UnityEngine;
using DG.Tweening;
public class DoorOpen : Interactable
{
    public Transform doorObject;
    private bool isOpen = false;
    public bool isLocked;
    public override void Interact()
    {
        base.Interact();
        if (isLocked)
        {
            Debug.Log("Kapý kilitli!");
            return;
        }
        isOpen = !isOpen;
        if (isOpen)
        {
            
        }
        else
        {
           
        }
    }
}
