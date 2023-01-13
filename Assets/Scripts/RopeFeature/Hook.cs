using UnityEngine;

namespace EccentricRope
{
    public class Hook : MonoBehaviour
    {
        private FixedJoint _fixedJoint;
        public new Rigidbody rigidbody;

        private void Start()
        {
            if(rigidbody == null)
                rigidbody = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(_fixedJoint == null)
            {
                _fixedJoint = gameObject.AddComponent<FixedJoint>();
                if (collision.rigidbody)
                {
                    _fixedJoint.connectedBody = collision.rigidbody;
                }
                
            }
        }

        public void StopFix()
        {
            if (_fixedJoint)
                Destroy(_fixedJoint);
        }
    }
}

