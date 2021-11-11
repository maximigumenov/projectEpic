using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mockup
{
    public class JumpZone : EventZone
    {
        private MoveToClass moveToClass;
        public List<Transform> targets;
        bool isJumpZone;
        public Transform jumpActionTransform;
        public float speed = 10;
        public bool ignoreRotate;

        private void Start()
        {
            
        }

        private void Update()
        {
            ShowMark();
            EventController();
            if (moveToClass != null)
            {
                moveToClass.Update();
            }
            if (!isJumpZone && !ignoreRotate)
            {
                jumpActionTransform.LookAtTarget(MainUnit.instance.transform);
            }
        }

        private void EventController()
        {
            if (isCanActive && inputData.Action && !isJumpZone)
            {
                Debug.Log("Jump");
                isJumpZone = true;
                moveToClass = new MoveToClass(MainUnit.instance.transform, targets, speed);
                moveToClass.OnFinish += Stop;
                MainUnit.BlockUnit();
                //StartCoroutine(JumpAction());
            }
        }

        private void Stop()
        {
            Debug.LogError("Stop");
            moveToClass = null;
            isJumpZone = false;
            MainUnit.ShowUnit();
        }



    }
}
