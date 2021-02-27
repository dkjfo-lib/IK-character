using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK_LookAt : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
        if (target == null)
            Debug.LogError("NO Target", this);
    }

    void LateUpdate()
    {
        if (target == null) return;
        transform.LookAt(target);
    }
}
