using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mockup
{
    public class MainUnit : Unit
    {

        public static MainUnit instance;
        private InputData inputData = new InputData();
        public List<MeshRenderer> meshRenderer;
        private static bool isBlock;
        public Transform targetLook;
        public Transform targetLookLeft;
        public Transform targetLookRight;
        [SerializeField]
        private UnitAnimation animation;
        

        private void Start()
        {
            instance = this;
        }

        private void Update()
        {
            UpdateInput();
            if (isMove && !isLeft && !isRight)
            {
                transform.LookAtTarget(targetLook);
            }
        }

        private void UpdateInput() {
            if (isCrouch && !EventZone.isEventZone)
            {
                isCrouch = false;
            }
            StartMove();
            if (isBlock)
            {
                return;
            }

            AlignAnimationRotation();
            isRun = inputData.Shift;
            MoveWait();
            if (inputData.Left)
            {
                MoveLeft();
            }
            if (inputData.Right)
            {
                MoveRight();
            }
            if (inputData.Up)
            {
                MoveForvard();
            }
            if (inputData.Down)
            {
                MoveBack();
            }
            ControlAnimation();
        }

        public void ControlAnimation() {
            if (!isMove)
            {
                if (isCrouch)
                {
                    animation.Crouch();
                }
                else
                {
                    animation.Idle();
                }
                
            }
            else if (isMove && isRun)
            {
                animation.Run();
            }
            else if (isMove && !isRun)
            {
                if (isCrouch)
                {
                    animation.CrouchWalk();
                }
                else
                {
                    animation.Walk();
                }
                
            }

            if (isMove && isLeft && isForvard)
            {
                animationTransform.localRotation = Quaternion.Euler(0, -45, 0);
            }
            else if (isMove && isRight && isForvard)
            {
                animationTransform.localRotation = Quaternion.Euler(0, 45, 0);
            }
            else if (isMove && isLeft && isBack)
            {
                animationTransform.localRotation = Quaternion.Euler(0, 225, 0);
            }
            else if (isMove && isRight && isBack)
            {
                animationTransform.localRotation = Quaternion.Euler(0, 135, 0);
            }

            else if (isMove && isLeft)
            {
                animationTransform.localRotation = Quaternion.Euler(0, -90, 0);
            }

            else if (isMove && isRight)
            {
                animationTransform.localRotation = Quaternion.Euler(0, 90, 0);
            }
            else if (isMove && isForvard)
            {
                animationTransform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            else if (isMove && isBack)
            {
                animationTransform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            
        }

        public static float GetDistance(Transform target) {
            return Vector3.Distance(instance.transform.position, target.position);
        }

        public static void HideUnit()
        {
            isBlock = true;
            foreach (var item in instance.meshRenderer)
            {
                if (item)
                {
                    item.enabled = false;
                }
            }
            
        }

        public static void BlockUnit()
        {
            isBlock = true;
        }

        public static void ShowUnit()
        {
            isBlock = false;
            foreach (var item in instance.meshRenderer)
            {
                item.enabled = true;
            }
            instance.SetCamera();
        }

    }
}
