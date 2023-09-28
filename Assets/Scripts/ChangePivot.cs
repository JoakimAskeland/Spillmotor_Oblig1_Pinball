using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePivot : MonoBehaviour
{
    public Vector3 newPivotPoint;

    // Start is called before the first frame update
    void Start()
    {
        // Finds difference between current and new pivot
        Vector3 pivotDifference = transform.position - transform.TransformPoint(newPivotPoint);

        // Use new pivot point
        transform.position = transform.TransformPoint(newPivotPoint);

        // Keep the local appearance
        transform.localPosition -= pivotDifference;
        transform.localRotation = Quaternion.identity;
    }

}
