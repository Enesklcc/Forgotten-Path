using UnityEngine;
using DG.Tweening;

public class Doors : Interactable
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
            doorObject.DOLocalRotate(new Vector3(currentRotation.x, 90, currentRotation.z), 1f);
        }
        else
        {
            Vector3 currentRotation = doorObject.localRotation.eulerAngles;
            doorObject.DOLocalRotate(new Vector3(0, 0, 0), 1f);
        }
    }
}