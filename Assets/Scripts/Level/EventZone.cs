using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Mockup
{
    public class EventZone : MonoBehaviour
    {
        public InputData inputData = new InputData();

        public Transform cameraMarkTarget;
        public Transform cameraMarkLook;
        [Space]
        public GameObject buttonMark;
        [Space]
        public float distanceToUnit = 4;
        public bool isActive;
        public UnityEvent activeEvent;
        public UnityEvent deactiveEvent;
        public bool isCanActive = false;

        public void SetCamera()
        {
            MoveCamera.SetTarget(cameraMarkTarget, cameraMarkLook);
        }

        public void HideUnit()
        {
            SetCamera();
            MainUnit.HideUnit();
        }

        public void ShowUnit()
        {
            MainUnit.ShowUnit();
        }

        public void ShowMark()
        {
            isCanActive = MainUnit.GetDistance(transform) < distanceToUnit;
            buttonMark.SetActive(isCanActive);
        }
    }
}
