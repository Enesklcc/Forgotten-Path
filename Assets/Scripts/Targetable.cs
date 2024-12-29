using UnityEngine;

public abstract class Targetable : MonoBehaviour
{
    public GameObject infoObject;

    public void ToggleHighligth(bool status)
    {
        infoObject.SetActive(status);
    }
}

