using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mockup
{
    public class MoveCamera : MonoBehaviour
    {
        private static MoveCamera instance;
        private static Transform targetMove;
        private static Transform targetLook;
        public float speed = 20;

        private void Start()
        {
            instance = this;
        }

        void Update()
        {
            transform.MoveToTarget(targetMove, speed);
            transform.LookAtTarget(targetLook, speed);
        }

        public static void SetTarget(Transform _targetMove, Transform _targetLook)
        {
            targetMove = _targetMove;
            targetLook = _targetLook;
        }
    }
}