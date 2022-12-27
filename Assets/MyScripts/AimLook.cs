using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingRange
{
    public class AimLook : MonoBehaviour
    {
        public float sens = 200f;
        public Transform player;
        float xRotation = 0f;

        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        void Update()
        {
            Mouse();

        }

        public void Mouse()
        {
            float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
            player.Rotate(Vector3.up * mouseX);
        }
    }
}
