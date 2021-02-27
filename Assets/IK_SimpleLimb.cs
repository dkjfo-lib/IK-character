using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK_SimpleLimb : MonoBehaviour
{
    const int N = 2;
    Transform[] parents = new Transform[N + 1];
    float[] radius = new float[N];
    public Transform target;

    void Awake()
    {
        if (target == null)
            Debug.LogError("NO Target", this);
        parents[0] = transform;
        parents[1] = transform.parent;
        parents[2] = transform.parent.parent;
        radius[0] = (parents[0].position - parents[1].position).magnitude;
        radius[1] = (parents[1].position - parents[2].position).magnitude;
    }

    //void LateUpdate()
    //{
    //    if (target == null) return;
    //    transform.position = target.position;
    //    var dir = (parents[1].position - parents[0].position).normalized;
    //    parents[1].position = parents[0].position + dir * radius[0];
    //}
}
