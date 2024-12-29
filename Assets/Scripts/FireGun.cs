using System.Collections;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public GameObject Gun;
    public GameObject Flash;
    private bool isFiring = false;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.5f;

    public Shake shakeScript;
    public Camera playerCamera;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && isFiring)
        {
            StartCoroutine(Fire());
            if (shakeScript!=null)
            {
                StartCoroutine(shakeScript.Shaking());
            }
            

        }
        
    }
  
    public IEnumerator Fire()
    {
        isFiring = true;

        Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point; 
        }
        else
        {
            targetPoint = ray.GetPoint(1000); 
        }

        Vector3 direction = (targetPoint - firePoint.position).normalized;
        Quaternion rotation = Quaternion.LookRotation(direction);

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, rotation);
        if (bullet != null)
        {
            Flash.SetActive(true);
            Flash.GetComponent<Animation>().Play("Shooting");
        }

        yield return new WaitForSeconds(fireRate);
        Flash.SetActive(false);
        isFiring = false;
    }
}