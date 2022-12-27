using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingRange
{
    public class TargetRange : MonoBehaviour
    {
        public bool isPractice;
        public float healt = 10f;
        public float startingHealt;


        void Start()
        {
            startingHealt = healt;

        }
        public void TakeDamage(float amount)
        {
            healt -= amount;

            if (healt <= 0)
            {
                Break();
            }
        }
        public void Break()
        {
            if (isPractice)
            {
                healt = startingHealt;
                gameObject.transform.position = new Vector3(Random.Range(-7, 7), Random.Range(0, 4), Random.Range(13, 5));

            }
            else
            {
                Destroy(gameObject);
            }



        }
    }
}
