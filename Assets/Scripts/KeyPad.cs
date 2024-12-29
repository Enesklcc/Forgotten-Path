using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class KeyPad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;
    public GameObject keypadNumber;

    public TMP_Text textOb;
    public string answer = "b1r2o3g4";
    private void Start()
    {
        keypadOB.SetActive(false);
    }
    public void Color(string color)
    {
        keypadNumber.SetActive(true);
        keypadOB.SetActive(false);
        textOb.text += color;
    }
    public void Execute()
    {
        if (textOb.text == answer)
        {
            textOb.text = "Right";
        }
        else
        {
            textOb.text = "Wrong";

        }
    }
    public void Clear()
    {
        textOb.text = "";
        keypadNumber.SetActive(false);
        keypadOB.SetActive(true);

    }
    public void Exit()
    {
        keypadOB.SetActive(false);
        keypadNumber.SetActive(false);
    }
    public void Update()
    {
        if (textOb.text == "Right")
        {
            Debug.Log("its open");
            return;
        }
        if (keypadOB.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
