using UnityEngine;

public class CabinetRight : Interactable
{
    public Animation cabinet;
    public bool isOpen;
    public override void Interact()
    {
        base.Interact();
        if (!isOpen)
        {
            cabinet.Play("cabinetOpenR");
            isOpen = true;
        }
        else
        {
            cabinet.Play("cabinetCloseR");
            isOpen = false;
        }
    }
}
