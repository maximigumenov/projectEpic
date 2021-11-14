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
        public bool isMove;
        public Transform animationTransform;



        public virtual void AlignAnimationRotation() {
            animationTransform.rotation = new Quaternion(0, 0, 0, 0);
        }

        public virtual void Initialization() { 
        
        }

        public virtual void UpdateUnit()
        {

        }

        public virtual void StartMove() {
            isMove = false;
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
            isMove = true;
        }

        public void MoveForvard()
        {
            controller.Move(controller.transform.forward * Time.deltaTime * playerSpeedCurrent);
            isMove = true;
        }

        public void MoveBack()
        {
            controller.Move(-controller.transform.forward * Time.deltaTime * playerSpeed / 2);
            isMove = true;
        }

        public void MoveLeft()
        {
            controller.Move(controller.transform.right * -1 * Time.deltaTime * playerSpeedCurrent);
            isMove = true;
        }

        public void MoveRight()
        {
            controller.Move(controller.transform.right * Time.deltaTime * playerSpeedCurrent);
            isMove = true;
        }

       
        
    }
}
