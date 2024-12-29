using UnityEngine;

public class Door : Interactable
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
            Vector3 currentRotation = doorObject.localRotation.eulerAngles;
            doorObject.Rotate(new Vector3(currentRotation.x, -90, currentRotation.z), 1f);
        }
        else
        {
            Vector3 currentRotation = doorObject.localRotation.eulerAngles;
            doorObject.Rotate(new Vector3(currentRotation.x, 0, currentRotation.z), 1f);
        }
    }
}