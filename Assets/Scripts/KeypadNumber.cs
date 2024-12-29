using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyPadNumber : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;
    public GameObject keypadNumber;


    public TMP_Text textOb;
    


    private void Start()
    {
        keypadOB.SetActive(false);
    }
    public void Number(int number)
    {
        keypadNumber.SetActive(false);
        keypadOB.SetActive(true);
        textOb.text += number.ToString();
    }
    
    
    public void Exit()
    {
        keypadOB.SetActive(false);
        keypadNumber.SetActive(false);
    }
    public void Update()
    {
 
        if (keypadNumber.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
