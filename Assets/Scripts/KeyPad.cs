using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;

    public TMP_Text textOb;
    public string answer = "b1r2o3g4";


    private void Start()
    {
        keypadOB.SetActive(false);
    }
    public void Number(int number)
    {
        textOb.text += number.ToString();
    }
    public void Color(string color)
    {
        textOb.text+=color;
    }
    public void Execute()
    {
        if (textOb.text==answer)
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

    }
    public void Exit()
    {
        keypadOB.SetActive(false);
    }
    public void Update()
    {
        if (textOb.text=="Right")
        {
            Debug.Log("its open");
        }
        if (keypadOB.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
