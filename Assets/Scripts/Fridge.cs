using UnityEngine;

public class Fridge : Interactable
{
    public Animation fridge;
    public bool isOpen;
    public override void Interact()
    {
        base.Interact();
        if (!isOpen)
        {
                fridge.Play("fridgeOpen");
                isOpen = true;
        }
        else
        {
            fridge.Play("fridgeClose");
            isOpen = false;
        }
    }
}
