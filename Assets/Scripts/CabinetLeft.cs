using UnityEngine;

public class CabinetLeft : Interactable
{
    public Animation cabinet;
    public bool isOpen;
    public override void Interact()
    {
        base.Interact();
        if (!isOpen)
        {
            cabinet.Play("cabinetOpenL");
            isOpen = true;
        }
        else
        {
            cabinet.Play("cabinetCloseL");
            isOpen = false;
        }
    }
}
