using UnityEngine;

public class OpenKeyPad : Interactable
{
    public GameObject keypadOB;
    public GameObject keypadNumber;


    public override void Interact()
    {
        base.Interact();
        keypadOB.SetActive(true);
    }
    
}
