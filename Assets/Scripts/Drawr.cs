using UnityEngine;

public class Drawr : Interactable
{
    public Animation drawer;
    public bool isOpen;
    public override void Interact()
    {
        base.Interact();
        if (!isOpen)
        {
            drawer.Play("drawerOpen");
            isOpen = true;
        }
        else
        {
            drawer.Play("drawerClose");
            isOpen = false;
        }
    }
}
