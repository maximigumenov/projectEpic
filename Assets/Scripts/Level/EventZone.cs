using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Mockup
{
    public class EventZone : MonoBehaviour
    {
        private static GameObject buttonMarkStatic;
        public InputData inputData = new InputData();
        public string tipsData;

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
            if (isCanActive)
            {
                buttonMarkStatic = buttonMark;
            }

            TextController();
        }

        public void TextController() {
            if (buttonMarkStatic == null)
            {
                return;
            }
            if (!buttonMarkStatic.activeInHierarchy)
            {
                MessageTextUI.Clear();
            }
            else
            {
                if (buttonMarkStatic == buttonMark)
                {
                    MessageTextUI.Tip(tipsData);
                }  
            }
        }
    }
}
