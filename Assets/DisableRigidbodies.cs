using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DisableRigidbodies : MonoBehaviour
{
    public bool Kinematic = false;
    public bool Weight = false;
    public bool Collisions = false;

    void Awake()
    {
        var rbs = GetComponentsInChildren<Rigidbody>();
        for (int i = 0; i < rbs.Length; i++)
        {
            rbs[i].isKinematic = Kinematic;
            rbs[i].useGravity = Weight;
            rbs[i].detectCollisions = Collisions;
        }
    }
}
