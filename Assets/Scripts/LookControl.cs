using UnityEngine;

public class LookControl : MonoBehaviour
{
    public float sens = 300f;
    public Transform body;

    private float xRot;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float vertical = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        xRot -= vertical;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        body.Rotate(Vector3.up * horizontal);
    }
}
