using UnityEngine;

namespace DitzelGames.FastIK
{
    public class FastIKLook : MonoBehaviour
    {
        public Transform Target;
        protected Vector3 StartDirection;
        protected Quaternion StartRotation;

        void Awake()
        {
            if (Target == null) return;
            StartDirection = Target.position - transform.position;
            StartRotation = transform.rotation;
        }

        void LateUpdate()
        {
            if (Target == null) return;
            transform.rotation = Quaternion.FromToRotation(StartDirection, Target.position - transform.position) * StartRotation;
        }
    }
}
