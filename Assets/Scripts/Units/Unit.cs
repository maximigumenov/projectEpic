using System.Collections.Generic;
using UnityEngine;

namespace Mockup
{
    public class Unit : MonoBehaviour
    {
        public Transform cameraMarkTarget;
        public Transform cameraMarkLook;
        [Space]
        public CharacterController controller;
        public float playerSpeed = 2.0f;
        public float playerSpeedRun = 4.0f;
        public float playerSpeedRotate = 1.0f;
        public float playerSpeedCurrent { get { return (isRun) ? playerSpeedRun : playerSpeed; } }
        public bool isRun = false;
        public float playerRun = 4.0f;

        public virtual void Initialization() { 
        
        }

        public virtual void UpdateUnit()
        {

        }

        public void LookAt(Transform targetLook) {
            transform.LookAtTarget(targetLook);
        }

        public void SetCamera()
        {
            MoveCamera.SetTarget(cameraMarkTarget, cameraMarkLook);
        }

        public void MoveWait() {
            controller.Move(Vector3.down * Time.deltaTime * playerSpeedCurrent);
        }

        public void MoveUp()
        {
            controller.Move(Vector3.up * Time.deltaTime * playerSpeedCurrent);
        }

        public void MoveForvard()
        {
            controller.Move(controller.transform.forward * Time.deltaTime * playerSpeedCurrent);
        }

        public void MoveBack()
        {
            controller.Move(-controller.transform.forward * Time.deltaTime * playerSpeed / 2);
        }

        public void MoveLeft()
        {
            controller.transform.Rotate(0, -playerSpeedRotate * Time.deltaTime * 100, 0);
        }

        public void MoveRight()
        {
            controller.transform.Rotate(0, playerSpeedRotate * Time.deltaTime * 100, 0);
        }

       
        
    }
}
