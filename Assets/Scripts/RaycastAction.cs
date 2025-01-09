using UnityEngine;

public class RayCastAction : MonoBehaviour
{
    private Camera cam;
    private Ray ray;
    private RaycastHit hit;

    private Targetable currentTargetable;
    private Collectable currentCollectable;
    private Interactable currentInteractable;

    public GameObject gun;
    public Transform gunHandPosition;

    public GameObject statue;
    public Transform statueHandPosition;

    public GameObject currentTarget;
    public GameObject holdObject;

    public GameObject statuePlace;
    public GameObject hiddenStatuePart;
    public GameObject statueUp;
    public GameObject statueDown;

    public GameObject hiddenNote;
    public GameObject hiddenKey;

    private bool hasStatue = false;
    private bool hasGun = false;
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        ray = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        if (Physics.Raycast(ray, out hit, 10))
        {
            if (hit.collider.TryGetComponent(out Targetable targetable))
            {
                currentTargetable = targetable;
                currentTargetable.ToggleHighligth(true);
                if (currentTargetable.TryGetComponent(out Collectable collectable))
                {
                    currentCollectable = collectable;
                }
                if (currentTargetable.TryGetComponent(out Interactable interactable))
                {
                    currentInteractable = interactable;
                }
            }
            else if (currentTargetable)
            {
                currentTargetable.ToggleHighligth(false);
                currentTargetable = null;
                if (currentCollectable)
                {
                    currentCollectable = null;
                }
                if (currentInteractable)
                {
                    currentInteractable = null;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentCollectable != null)
            {
                if (currentCollectable.gameObject == gun)
                {
                    hasGun = true;
                    gun.transform.SetParent(gunHandPosition);
                    gun.transform.localPosition = Vector3.zero;
                    gun.transform.localRotation = Quaternion.identity;
                    var fireGunScript = gun.GetComponent<FireGun>();

                    currentCollectable = null;
                }
                else if (currentCollectable.gameObject == statueUp)
                {
                    hasStatue = true;
                    statueUp.transform.SetParent(statueHandPosition);
                    statueUp.transform.localPosition = Vector3.zero;
                    statueUp.transform.localRotation = Quaternion.Euler(15,0,0);
                    hiddenStatuePart.SetActive(false);
                    currentCollectable = null;
                }
                else if (currentCollectable.CompareTag("Collectable"))
                {
                    currentCollectable.Collect();
                    currentCollectable = null;
                }
            }
            if (hit.collider != null && hit.collider.gameObject == statueDown)
            {
                if (hasStatue)
                {
                    Destroy(statueUp);
                    hiddenStatuePart.SetActive(true); 
                    hasStatue = false; 
                    hiddenNote.SetActive(true);
                    hiddenKey.SetActive(true);

                }
            }
            if (currentInteractable)
            {
                currentInteractable.Interact();
            }
        }
    }

    void InteractWithObject(GameObject target)
    {
        if (holdObject != null)
        {
            Destroy(holdObject);
        }
        target.SetActive(true);
    }
}