using UnityEngine;
using UnityEngine.UI;

public class Notes : Interactable
{
    public GameObject noteScreen;
    public Image note_Image;
    public Sprite note1;
    public override void Interact()
    {
        base.Interact();
        noteScreen.SetActive(true);
        note_Image.sprite = note1;

       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            noteScreen.SetActive(false);
            note_Image.sprite = null;
        }
    }
}
