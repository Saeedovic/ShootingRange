using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingRange
{
    public class Shooting : MonoBehaviour
    {
        public float firingRate = 15f;
        public float dmg = 10f;
        public float range = 100f;

        public float impactForce = 100f;

        public Camera cam;
        private float shootTime = 0f;

        void Start()
        {

        }

        private void Update()
        {
            
            if (Input.GetButtonDown("Fire1") && Time.time > shootTime)
            {
                shootTime = Time.time + 1f / firingRate;

                Shoot();
            }


        }
        public void Shoot()
        {
            RaycastHit hit;

            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);


                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * impactForce);
                }
                TargetRange target = hit.transform.GetComponent<TargetRange>();

                if (target != null)
                {
                    target.TakeDamage(dmg);
                }

            }
        }

        /*public void Fire()
        {
            if (Time.time > shootTime)
            {
                shootTime = Time.time + 1f / firingRate;

                Shoot();
            }

        }
*/
    }
}


