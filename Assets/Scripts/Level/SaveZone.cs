using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Mockup
{
    public class SaveZone : MonoBehaviour
    {
        private InputData inputData = new InputData();
        public Transform cameraMarkTarget;
        public Transform cameraMarkLook;
        [Space]
        public GameObject buttonMark;
        [Space]
        public float distanceToUnit = 4;
        private bool isActive;
        public UnityEvent activeEvent;
        public UnityEvent deactiveEvent;


        private bool isCanActive = false;

        private void Update()
        {
            ShowMark();
            EventController();
        }

        private void EventController() {
            if (isCanActive && inputData.Action)
            {
                if (!isActive)
                {
                    isActive = true;
                    activeEvent?.Invoke();
                }
                else
                {
                    isActive = false;
                    deactiveEvent?.Invoke();
                }
            }
        }


        public void SetCamera()
        {
            MoveCamera.SetTarget(cameraMarkTarget, cameraMarkLook);
        }


        public void ShowMark() {
            isCanActive = MainUnit.GetDistance(transform) < distanceToUnit;
            buttonMark.SetActive(isCanActive);
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


    }
}
