using UnityEngine;
using DG.Tweening;

public class Drawr : Interactable
{
    public Transform drawrObject;
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
            Vector3 currentRotation = drawrObject.localRotation.eulerAngles;
            drawrObject.DOLocalRotate(new Vector3(currentRotation.x, currentRotation.y, currentRotation.z), 1f);
        }
        else
        {
            Vector3 currentRotation = drawrObject.localRotation.eulerAngles;
            drawrObject.DOLocalRotate(new Vector3(0, 0, 0), 1f);
        }
    }
}