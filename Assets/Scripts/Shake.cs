using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour
{
    public AnimationCurve curve;
    public float duration = 1f;

    public Transform target; 
    private Vector3 initialPosition; 

    void Start()
    {
        if (target != null)
        {
            initialPosition = target.localPosition;
        }
    }

    public IEnumerator Shaking()
    {
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            target.localPosition = initialPosition + Random.insideUnitSphere * strength;
            yield return null;
        }

        target.localPosition = initialPosition;
    }
}