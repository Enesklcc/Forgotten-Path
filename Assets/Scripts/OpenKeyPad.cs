using UnityEngine;

public class OpenKeyPad : Interactable
{
    public GameObject keypadOB;

    public override void Interact()
    {
        base.Interact();
        keypadOB.SetActive(true);
    }
    
}
