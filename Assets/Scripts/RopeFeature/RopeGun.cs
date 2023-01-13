using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EccentricRope
{
    public class RopeGun : MonoBehaviour
    {
        public Hook hook;
        public Transform spawn;
        public float speed;

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(2))
            {
                Shot();
            }
        }

        void Shot()
        {
            hook.StopFix();
            hook.transform.position = spawn.position;
            hook.transform.rotation = spawn.rotation;
            hook.rigidbody.velocity = spawn.forward * speed;
        }
    }
}
